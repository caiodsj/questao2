using System;

class Program {
    static void Main(string[] args) {
        string str = "Target";
        char[] charArray = str.ToCharArray();
        int length = charArray.Length;

        for (int i = 0; i < length / 2; i++) {
            char temp = charArray[i];
            charArray[i] = charArray[length - i - 1];
            charArray[length - i - 1] = temp;
        }

        string strInvertida = new string(charArray);
        Console.WriteLine("String original: " + str);
        Console.WriteLine("String invertida: " + strInvertida);
    }
}
