﻿// the ourAnimals array will store the following: 
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
bool validEntry = false;
int petAge = 0;
// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];



// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do {
Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}

//Console.WriteLine($"You selected menu option {menuSelection}.");
//Console.WriteLine("Press the Enter key to continue");

// pause code execution
//readResult = Console.ReadLine();

switch (menuSelection){
    case "1":
        for (int i = 0; i < maxPets; i++){
            if (ourAnimals [i,0] != "ID #: "){
                Console.WriteLine(ourAnimals[i, 0]);
                for (int j = 0; j < 6; j++){
                    Console.WriteLine(ourAnimals [i,j]);
                }
            }
        }
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "2":
        string anotherPet = "y";
        int petCounter = 0;
        for (int i = 0; i < maxPets; i++){
            if (ourAnimals[i,0] != "ID #: "){
                petCounter += 1;}
        }
        if (petCounter < maxPets){
                Console.WriteLine($"We currently have {petCounter} pets that need homes. We can manage {(maxPets - petCounter)} more.");
        }
      
        do{
            Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
            readResult = Console.ReadLine();
            if (readResult != null){
                animalSpecies = readResult.ToLower();
                if (animalSpecies != "dog" && animalSpecies != "cat"){
                    validEntry = false;
                } else {
                    validEntry = true;
                }
            }   
        } while (validEntry == false);
        
        animalID = animalSpecies.Substring(0,1) + (petCounter + 1).ToString();
        
        do{
            Console.WriteLine("Enter the pet's age or enter ? if unknown");
            readResult = Console.ReadLine();
            if (readResult != null){
                animalAge = readResult;
                if (animalAge != "?"){
                    validEntry = int.TryParse(animalAge, out petAge);
                } else {
                    validEntry = true;
                }
            }
        } while(validEntry == false);
        
        do{
            Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
            readResult = Console.ReadLine();
            if (readResult != null){
                animalPhysicalDescription = readResult.ToLower();
                if(animalPhysicalDescription == ""){
                    animalPhysicalDescription = "tbd";
                }
            }
        } while (animalPhysicalDescription == "");
        
        do{
            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
            readResult = Console.ReadLine();
            if (readResult != null){
                animalPhysicalDescription = readResult.ToLower();
                if (animalPersonalityDescription == ""){
                    animalPersonalityDescription = "tbd";
                }
            }
        } while (animalPersonalityDescription == "");

        do{
            Console.WriteLine("Enter a nickname for the pet");
            readResult = Console.ReadLine();
            if (animalNickname != null){
                animalNickname = readResult.ToLower();
                if ( animalNickname == ""){
                    animalNickname = "tbd";
                }
            }
        } while (animalNickname == "");

            ourAnimals[petCounter, 0] = "ID#: " + animalID;
            ourAnimals[petCounter, 1] = "Species: " + animalSpecies;
            ourAnimals[petCounter, 2] = "Age: " + animalAge;
            ourAnimals[petCounter, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCounter, 4] = "Physical descripition: " + animalPersonalityDescription;
            ourAnimals[petCounter, 5] = "Personality: " + animalPersonalityDescription;
            
        while  (anotherPet == "y" && petCounter < maxPets){
            petCounter = petCounter + 1;
            if (petCounter < maxPets){
                Console.WriteLine("Do you want to add another pet?(y/n)");
            }
        do { readResult = Console.ReadLine();
        if (readResult != null){
            anotherPet = readResult.ToLower();
        }
        } while (anotherPet != "y" && anotherPet != "n");
        }
        if (petCounter >= maxPets){
            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
        }
        break;
    case "3":        
        for (int i = 0; i < maxPets; i++){
            if(ourAnimals[i, 2] == "Age: ?" &&  ourAnimals[i, 0] != "ID #: "){
                do { 
                    Console.WriteLine($"Enter a age for {ourAnimals[i, 0]}");
                    readResult = Console.ReadLine();
                    if (readResult != null){
                        animalAge = readResult;
                        validEntry = int.TryParse(animalAge, out petAge);
                    }
                } while(validEntry == false);
                ourAnimals[i,2] = "Age: " + animalAge.ToString();
            }

            if (ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 0] != "ID #: "){
                do {
                    Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if(readResult != null){
                        animalPhysicalDescription = readResult.ToLower();
                        if(animalPhysicalDescription == ""){
                            validEntry = false;
                        }else {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
        }
            } 
            Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;
    case "4":
        for(int i = 0; i < maxPets; i++)
        
        if(ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 0] != "ID #: "){
        do {
             Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
             readResult = Console.ReadLine();
             if (readResult != null){
                animalNickname = readResult.ToLower();
                if (animalNickname == ""){
                    validEntry = false;
                } else {
                    validEntry = true;
                }
             }
        } while (validEntry == false);
        ourAnimals[i, 3] = "Nickname: " + animalNickname;
        
        if (ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 0] != "ID #: "){
            do {
                Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
                readResult = Console.ReadLine();
                if (readResult != null){
                    animalPersonalityDescription = readResult.ToLower();
                    if (animalPersonalityDescription == ""){
                        validEntry = false;
                    } else {
                        validEntry = true;
                    }
                }
             } while (validEntry == false);
             ourAnimals[i,5] = "Pesonality: " + animalPersonalityDescription;
        }
        }
         Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
        readResult = Console.ReadLine();
        break;
    case "5":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "6":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "7":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "8":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    default:
        break;
}

} while (menuSelection != "exite");

