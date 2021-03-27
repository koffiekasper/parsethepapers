﻿using System;
using System.IO;
using System.Collections.Generic;
using Parsethepapers.Classes;

namespace Parsethepapers
{
    class Program
    {
        public static bool ContainsCommand(string line){
            if (!line.Contains("issued server command: ")){
                return false;
            } return true;
        }

        public static bool ContainsCommand(string[] commands, string line){
            if (!line.Contains("issued server command:")){
                return false;
            }
            string matchPattern;
            for (int i = 0; i < commands.Length; i++){
                matchPattern = "/" + commands[i] + " ";
                if (line.Contains(matchPattern)){
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsLogin(string line){
            return line.Contains("] logged in with entity id");
        }

        public static bool ContainsLogoff(string line){
            return line.Contains(" lost connection: ");
        }
        static void Main(string[] args)
        {
            // Stores the last recipient of a private message between players. Used to track the recipient for a /r command
            Dictionary<string, string> lastRecipient =
                new Dictionary<string, string>();

            Dictionary<string, string[]> messages =
                new Dictionary<string, string[]>();

            string[] privateMessageCommands = {"msg", "w", "t", "pm", "emsg", "epm", "tell", "etell", "whisper", "ewhisper"};
            string[] replyCommands = {"r", "er", "reply", "ereply"};
            
            using (StreamReader sr = new StreamReader("./logs.txt")) {
                string line;
                while ((line = sr.ReadLine()) != null){
                    if (ContainsCommand(privateMessageCommands, line) || ContainsCommand(replyCommands, line)) {
//                        Console.WriteLine(line);
                    } else if (ContainsLogin(line)){
                        Console.WriteLine(line);
                    } else if (ContainsLogoff(line)){
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}