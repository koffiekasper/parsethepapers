using System;
using System.Collections.Generic;

namespace Parsethepapers.Classes
{
    public class OnlinePlayers
    {
        HashSet<string> players = new HashSet<string>();
        public OnlinePlayers(){
        }

        public void PlayerJoins(string player){
            this.players.Add(player.ToUpper());
            this.PrintList();
        }

        public void PlayerLeaves(string player){
            this.players.Remove(player.ToUpper());
            this.PrintList();
        }

        public void PrintList(){
            Console.Clear();
            Console.WriteLine("Players online: " + this.players.Count);
            foreach (string i in this.players){
                Console.WriteLine("\t" + i);
            }
        }

        public string shortFor(string alias){
            alias = alias.ToUpper();
            foreach (string i in this.players){
                if (i.Contains(alias)){
                    if (i.StartsWith(alias)){
                        return i;
                    }
                }
            }
            return "N/A";
        }
    }
}