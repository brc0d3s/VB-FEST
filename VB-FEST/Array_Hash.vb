Module Array_Hash
    Sub Main()
        Dim hashTab As Hashtable = New Hashtable()
        Dim j As DictionaryEntry
        'Use of Add() function  
        hashTab.Add("str", "VB.NET")
        hashTab.Add("05", "Peter")
        hashTab.Add("06", "Hamilton")
        hashTab.Add("07", "Universe")
        hashTab.Add("08", "Welcome")
        hashTab.Add("09", 90)
        hashTab.Add("site", "JavaTpoint")
        hashTab.Add("planet", "Earth")

        For Each j In hashTab
            Console.WriteLine(" Key = {0}, Value = {1}", j.Key, j.Value)
        Next j
        Console.WriteLine()

        ' Use of ContainsValue() function  
        If hashTab.ContainsValue("Earth") Then
            Console.WriteLine(" Value 'Earth' is exist")
        Else
            Console.WriteLine(" Doesn't exist")
        End If
        Console.WriteLine(" Total keys in HashTable {0}", hashTab.Count)

        'Display a Single item.  
        Console.WriteLine("Display a Single item is '{0}' from HashTab", hashTab("07"))

        'Use of ContainsKey() function  
        'Console.WriteLine(" Is the key '05' exist : {0) ", hashTab("05"))  

        'Use of Remove() function  
        Console.WriteLine(" Remove key 07 from HashTab ")
        hashTab.Remove("07")
        For Each j In hashTab
            Console.WriteLine(" Key = {0}, Value = {1}", j.Key, j.Value)
        Next j

        Console.WriteLine(" Press any key to exit")
        Console.ReadKey()
    End Sub
End Module
