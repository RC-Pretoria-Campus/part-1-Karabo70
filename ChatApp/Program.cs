using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using NAudio.SoundFont;
using System.Speech.Synthesis;
using System.Net.Http.Headers;

namespace ChatbotApp
{

    class Program

    {
        static void Main(string[] args)
        {
            // Play the voice greeting 
            PlayVoiceGreeting();
            // Display ASCII art (Cybersecurity Awareness Bot logo) 
            DisplayAsciiLogo();
            // Greet the user and ask for their name 
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            if (string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("You didn't enter a name. Please try again.");
                return;
            }
            Console.WriteLine($"Hello, {userName}! Welcome to the Cybersecurity Awareness Bot!");
            // Simulate typing effect and ask user about how they need help 
            TypeText("I am here to help you stay safe online by providing some cybersecurity tips...");
            // Respond to user queries 
            RespondToQueries();
            // Handle input validation example 
            InputValidation();
        }
        // Method to play the voice greeting when the chatbot starts 

        static void PlayVoiceGreeting()
        {

            try
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                Console.WriteLine("Welcome to the Cybersecurity Awareness chatbot!");
                synth.Speak("Welcome to the Cybersecurity Awareness chatbot! Ask me anything about online safety.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing the voice greeting: " + ex.Message);
            }
        }
        // Method to display the ASCII logo or art of the chatbot 
        static void DisplayAsciiLogo()

        {
            Console.WriteLine(@" 

| |     / /  | |\ \          / /| |
| |    / /   | | \ \        / / | |
| |   / /    | |  \ \      / /  | |
| |  / /     | |   \ \    / /   | |
| | / /      | |    \ \  / /    | |
| |/ /       | |     \ \/ /     | |
| |\ \       | |                | |
| | \ \      | |                | | 
| |  \ \     | |                | |  
| |   \ \    | |                | |
| |    \ \   | |                | |
| |     \ \  | |                | |
");

        }
        // Method to simulate typing effect 
        static void TypeText(string message)

        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(50); // Simulate typing delay 
            }
            Console.WriteLine();
        }
        // Updated method to respond to user queries using if-else statements 

        static void RespondToQueries()
        {
            Console.WriteLine("Ask me anything about cybersecurity. Type 'exit' to quit.");
            string input;
            while ((input = Console.ReadLine().ToLower()) != "exit")
            {
                if (input == "how are you?")
                {
                    Console.WriteLine("I'm doing well, thank you for asking!");
                }
                else if (input == "what's your purpose?")
                {
                    Console.WriteLine("My purpose is to help you stay safe online by providing cybersecurity tips and answering your questions.");
                }
                else if (input == "what can I ask you about?")
                {
                    Console.WriteLine("You can ask me about topics like password safety, phishing, safe browsing, two-factor authentication, and more.");
                }
                else if (input == "what is phishing?")
                {
                    Console.WriteLine("Phishing is also a form of cyber attack wherein some person attempts to fool you out of personal or confidential details like password, credit card details, or login credentials by impersonating a friend. ");
                }
                else if (input == "how can I create a strong password?")
                {
                    Console.WriteLine("Use a mix of uppercase, lowercase, numbers, and special characters. Avoid common words or personal info. Consider using a password manager.");
                }
                else if (input == "what is two-factor authentication?")
                {
                    Console.WriteLine("Two-factor authentication (2FA) is an additional layer of protection that provides additional security to your accounts. Rather than using only your password, 2FA will have two different methods of authenticating to log in");
                }
                else if (input == "how do I know if a website is safe?")
                {
                    Console.WriteLine("Check for HTTPS in the address bar, look for a padlock icon, and make sure the domain name is correct. Be cautious of sites with lots of pop-ups or bad grammar.");
                }
                else if (input == "what should I do if I think I clicked a phishing link?")
                {
                    Console.WriteLine("Disconnect from the internet, run a full antivirus scan, change your passwords, and monitor your accounts for suspicious activity.");
                }
                else if (input == "is public wi-fi safe?" || input == "is public wifi safe?")
                {
                    Console.WriteLine("Public Wi-Fi can be risky. Avoid logging into sensitive accounts. Use a VPN if possible.");
                }
                else if (input == "what is a vpn?")
                {
                    Console.WriteLine("A VPN (Virtual Private Network) encrypts your internet connection, making it safer to browse, especially on public networks.");
                }
                else if (input == "how often should I update my software?")
                {
                    Console.WriteLine("As soon as updates are available! Updates often fix security vulnerabilities.");
                }
                else
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase or ask about another cybersecurity topic?");
                }
            }
        }
        // Method to handle input validation and guide the user if no valid input is entered 

        static void InputValidation()
        {
            Console.Write("Please type a question: ");
            string userInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("You didn't enter anything. Please type a valid question.");
            }
            else
            {
                Console.WriteLine("Thank you for your input! Now, how else can I help/assist you?");
            }

        }

    }

}