using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO.MemoryMappedFiles;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Collections;
using System.Text;
using System.IO;
using System.Threading;
using System.Linq;

public class fileData
{
    public string FileName { get; private set; }
    public byte[] Data { get; set; }
    public DateTime DateTime { get; private set; }
    public long Size { get; private set; }

    private keysContainer KC;

    public fileData(string fileName, byte[] data, DateTime creationTime, long size)
    {
        FileName = fileName;
        Data = data;
        DateTime = creationTime;
        Size = size;
    }

    private class keysContainer
    {
        private byte[] privateKey;
        private Stack<byte[]> computedKeys;
        private static Random random = new Random();

        public keysContainer()
        {
            // Initialize (with random sting) and encrypt the private key
            privateKey = new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(RandomString(0x400)));
            computedKeys = new Stack<byte[]>();
        }

        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void addNewComputedKey(string newKey)
        {
            byte[] userKey = ASCIIEncoding.ASCII.GetBytes(newKey);

            byte[] computedNewKey = new byte[privateKey.Length];

            for (int i = 0, j = 0; i < computedNewKey.Length; i++, j++)
            {
                if (j >= userKey.Length) j = 0;
                int x = privateKey[i] + userKey[j];
                computedNewKey[i] = (byte)x;
            }

            computedKeys.Push(computedNewKey);
        }

        public bool validateKey(string KeyToCheck)
        {
            if (computedKeys.Count == 0) return false;

            byte[] userKey = ASCIIEncoding.ASCII.GetBytes(KeyToCheck);

            byte[] computedNewKey = new byte[privateKey.Length];

            for (int i = 0, j = 0; i < computedNewKey.Length; i++, j++)
            {
                if (j >= userKey.Length) j = 0;
                int x = privateKey[i] + userKey[j];
                computedNewKey[i] = (byte)x;
            }
            if (!ByteArrayCompare(computedKeys.Peek(), computedNewKey))
                return false;

            else
            {
                computedKeys.Pop();
                return true;
            }
        }
    }

    static bool ByteArrayCompare(byte[] a1, byte[] a2)
    {
        return StructuralComparisons.StructuralEqualityComparer.Equals(a1, a2);
    }

    public void newEncryption(string userKey)
    {
        if (KC == null) KC = new keysContainer();
        KC.addNewComputedKey(userKey);
    }

    public bool keyValidation(string userKey)
    {
        return KC.validateKey(userKey);
    }

    public override string ToString()
    {
        return this.FileName + ", " + this.DateTime.ToString() + ", " + this.Size;
    }
}


class TinyMemFS
{
    public ConcurrentDictionary<string, fileData> memoryFiles;
    public TinyMemFS()
    {
        // constructor
        this.memoryFiles = new ConcurrentDictionary<string, fileData>();
    }

    /// <summary>
    ///     fileName - The name of the file to be added to the file system
    ///     fileToAdd - The file path on the computer that we add to the system
    ///     return false if operation failed for any reason
    ///     Example:
    ///     add("name1.pdf", "C:\\Users\\user\Desktop\\report.pdf")
    ///     note that fileToAdd isn't the same as the fileName
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="fileToAdd"></param>
    /// <returns></returns>
    public bool add(String fileName, String fileToAdd)
    {
        try
        {
            byte[] buffer = null;
            using (FileStream fs = new FileStream(fileToAdd, FileMode.Open, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
                DateTime creationDate = File.GetCreationTime(fileToAdd);

                fileData fileData = new fileData(fileName, buffer, creationDate, fs.Length);

                if (!this.memoryFiles.TryAdd(fileName, fileData))
                    return false;
                fs.Dispose();
            }
        }
        catch
        {
            return false;
        }
        return true;
    }

    /// <summary>
    ///     fileName - remove fileName from the system
    ///     this operation releases all allocated memory for this file
    ///     return false if operation failed for any reason
    ///     Example:
    ///     remove("name1.pdf")
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public bool remove(String fileName)
    {
        bool removed = false;
        try
        {
            fileData itemToRemove;
            removed = this.memoryFiles.TryRemove(fileName, out itemToRemove);
            if (!removed)
                Console.WriteLine("not removed this time");
        }
        catch
        {
            return false;
        }
        return removed;
    }

    /// <summary>
    ///     The function returns a list of strings with the file information in the system
    ///     Each string holds details of one file as following: "fileName,size,creation time"
    ///     Example:{
    ///     "report.pdf,630KB,Friday, ‎May ‎13, ‎2022, ‏‎12:16:32 PM",
    ///     "table1.csv,220KB,Monday, ‎February ‎14, ‎2022, ‏‎8:38:24 PM" }
    ///     You can use any format for the creation time and date    /// </summary>
    /// <returns></returns>
    public List<String> listFiles()
    {
        Monitor.Enter(this.memoryFiles);
        List<String> files = null;
        try
        {
            files = new List<string>();

            KeyValuePair<string, fileData>[] currentFiles = this.memoryFiles.ToArray();

            foreach (KeyValuePair<string, fileData> keyValuePair in currentFiles)
            {
                files.Add(keyValuePair.Value.FileName + "," + (keyValuePair.Value.Size / 1024) + "KB," + keyValuePair.Value.DateTime.ToString());
            }
        }
        finally
        {
            Monitor.Exit(this.memoryFiles);
        }
        return files;
    }

    /// <summary>
    ///     this function saves file from the TinyMemFS file system into a file in the physical disk
    ///     fileName - file name from TinyMemFS to save in the computer
    ///     fileToAdd - The file path to be saved on the computer
    ///     return false if operation failed for any reason
    ///     Example:
    ///     save("name1.pdf", "C:\\tmp\\fileName.pdf")
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="fileToAdd"></param>
    /// <returns></returns>
    public bool save(String fileName, String fileToAdd)
    {
        try
        {
            fileData temp;
            if (!this.memoryFiles.TryGetValue(fileName, out temp)) return false;
            File.WriteAllBytes(fileToAdd, temp.Data);
        }
        catch
        {
            return false;
        }
        return true;
    }

    /// <summary>
    ///     key - Encryption key to encrypt the contents of all files in the system 
    ///     You can use an encryption algorithm of your choice
    ///     return false if operation failed for any reason
    ///     Example:
    ///     encrypt("myFSpassword")
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public bool encrypt(String key)
    {
        Monitor.Enter(this.memoryFiles);
        try
        {
            foreach (KeyValuePair<String, fileData> kvp in this.memoryFiles)
            {
                //encrypt public key and file content based on private key
                try
                {
                    byte[] encrypted = encryptFile(kvp.Value.Data, key);
                    if (encrypted == null) return false;

                    //set file encrypted
                    kvp.Value.Data = encrypted;
                    kvp.Value.newEncryption(key);
                }
                catch
                {
                    return false; // return false if the key is not in a correct size
                }
            }
        }
        finally
        {
            Monitor.Exit(this.memoryFiles);
        } 
        return true;

    }

    //our function
    //if null return false
    private byte[] encryptFile(byte[] toEncrypt, string key)
    {
        MemoryStream ms = new MemoryStream();
        Aes aes = new AesManaged();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = new byte[aes.IV.Length];
        CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
        cs.Write(toEncrypt, 0, toEncrypt.Length);
        cs.FlushFinalBlock();
        cs.Close();
        return ms.ToArray();
    }

    /// <summary>
    ///     fileName - Decryption key to decrypt the contents of all files in the system 
    ///     return false if operation failed for any reason
    ///     Example:
    ///     decrypt("myFSpassword")
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public bool decrypt(String key)
    {
        Monitor.Enter(this.memoryFiles);
        try
        {
            foreach (KeyValuePair<String, fileData> kvp in this.memoryFiles)
            {
                //decrypt only file who are encrypted
                if (!kvp.Value.keyValidation(key)) return false;
                byte[] decrypted = decryptFile(kvp.Value.Data, key);
                if (decrypted == null) return false;
                if (decrypted.Length == 0) continue;//wrong key for current data

                //mark as decrypted
                kvp.Value.Data = decrypted;
            }
        }
        catch
        {
            return false;
        }
        finally
        {
            Monitor.Exit(this.memoryFiles);
        } 
        return true;
    }

    //our function
    //if null return false
    private byte[] decryptFile(byte[] toDecrypt, string key)
    {
        MemoryStream ms = new MemoryStream();
        Aes aes = new AesManaged();
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = new byte[aes.IV.Length];
        CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);
        cs.Write(toDecrypt, 0, toDecrypt.Length);
        cs.FlushFinalBlock();
        cs.Close();
        return ms.ToArray();
    }

    // ************** NOT MANDATORY ********************************************
    // ********** Extended features of TinyMemFS ********************************
    public bool saveToDisk(String fileName)
    {
        /*
         * Save the FS to a single file in disk
         * return false if operation failed for any reason
         * You should store the entire FS (metadata and files) from memory to a single file.
         * You can decide how to save the FS in a single file (format, etc.) 
         * Example:
         * SaveToDisk("C:\\tmp\\MYTINYFS.DAT")
         */
        return false;
    }

    public bool loadFromDisk(String fileName)
    {
        /*
         * Load a saved FS from a file  
         * return false if operation failed for any reason
         * You should clear all the files in the current TinyMemFS if exist, before loading the filenName
         * Example:
         * LoadFromDisk("C:\\tmp\\MYTINYFS.DAT")
         */
        return false;
    }

    public bool compressFile(String fileName)
    {
        /* Compress file fileName
         * return false if operation failed for any reason
         * You can use an compression/uncompression algorithm of your choice
         * Note that the file size might be changed due to this operation, update it accordingly
         * Example:
         * compressFile ("name1.pdf");
         */
        return false;
    }

    public bool uncompressFile(String fileName)
    {
        /* uncompress file fileName
         * return false if operation failed for any reason
         * You can use an compression/uncompression algorithm of your choice
         * Note that the file size might be changed due to this operation, update it accordingly
         * Example:
         * uncompressFile ("name1.pdf");
         */
        return false;
    }

    public bool setHidden(String fileName, bool hidden)
    {
        /* set the hidden property of fileName
         * If file is hidden, it will not appear in the listFiles() results
         * return false if operation failed for any reason
         * Example:
         * setHidden ("name1.pdf", true);
         */
        return false;
    }

    public bool rename(String fileName, String newFileName)
    {
        /* Rename filename to newFileName
         * Return false if operation failed for any reason (E.g., newFileName already exists)
         * Example:
         * rename ("name1.pdf", "name2.pdf");
         */
        return false;
    }

    public bool copy(String fileName1, String fileName2)
    {
        /* Rename filename1 to a new filename2
         * Return false if operation failed for any reason (E.g., fileName1 doesn't exist or filename2 already exists)
         * Example:
         * rename ("name1.pdf", "name2.pdf");
         */
        return true;
    }

    public void sortByName()
    {
        /* Sort the files in the FS by their names (alphabetical order)
         * This should affect the order the files appear in the listFiles 
         * if two names are equal you can sort them arbitrarily
         */
        return;
    }

    public void sortByDate()
    {
        /* Sort the files in the FS by their date (new to old)
         * This should affect the order the files appear in the listFiles  
         * if two dates are equal you can sort them arbitrarily
         */
        return;
    }

    public void sortBySize()
    {
        /* Sort the files in the FS by their sizes (large to small)
         * This should affect the order the files appear in the listFiles  
         * if two sizes are equal you can sort them arbitrarily
         */
        return;
    }

    public bool compare(String fileName1, String fileName2)
    {
        /* compare fileName1 and fileName2
         * files considered equal if their content is equal 
         * Return false if the two files are not equal, or if operation failed for any reason (E.g., fileName1 or fileName2 not exist)
         * Example:
         * compare ("name1.pdf", "name2.pdf");
         */
        return false;
    }

    public Int64 getSize()
    {
        /* return the size of all files in the FS (sum of all sizes)
         */
        return 0;
    }
}