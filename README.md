# WORD COUNTER

Console based app that can count the occurences of a chosen word in given a sentence. 

### USE

Built for Epicodus' C# Testing independent review. Takes a user inputted sentence and word and counts how many times that word is in the sentence. An example input and output would be:
- word: cat
- sentence: this cat is a good cat
- prints to console that the sentence contains the word cat twice. 

### SET-UP

1. clone repository from github and use 'dotnet restore WordCounter.Tests WordCounter' in command line;
2. to launch program use 'dotnet run' from WordCounter folder in a command line, the app will run in a terminal;
3. to check tests, navigate to WordCounter.Tests directory and enter 'dotnet test' to run;

### SPECS

| Behavior | Input | Output |
|-|-|-|
| user can enter a sentence | "for the people by the people" | sentence: for the people by the people |
| user can enter the word to be counted | "people" | word: people |
| program will count the occurences of word | _given sentence and word_ | "there are 2 occurences of the word 'people'" |
| prompt user to enter new sentence or to exit | "yes/exit" | _runs again/exits_ |


### TECHNOLOGIES

C#, .NET, MSTest

### AUTHORS

Loewy Malkovich, loewymalkov@gmail.com

### LICENSE

Free use license, MIT (2019)
