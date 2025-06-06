using System;
class String2 {
    public static void Main(String[] args) {
        String input = "Hello world from c#";
        String[] words = input.Split(' ');
        String output = "";

        for (int i = 0; i < words.Length; i++) {
            String inputWord = words[i];
            // Check if inputWord is not empty to prevent errors
            if (inputWord.Length > 0) {
                for (int j = inputWord.Length - 1; j >= 0; j--) {
                    output += inputWord[j];
                }
                output += " ";
            }
        }

        Console.WriteLine(output);
    }
}
