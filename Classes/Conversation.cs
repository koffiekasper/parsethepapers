using System;
using System.Collections.Generic;

namespace Parsethepapers.Classes
{
    public class Conversation
    {
        string player1;
        string player2;
        List<Tuple<string, string, string>> messages = new List<Tuple<string, string, string>>();

        public Conversation(string player1, string player2){
            this.player1 = player1;
            this.player2 = player2;
        }

        public void AddMessage(string sender, string receiver, string message){
            messages.Add(new Tuple<string, string, string>(sender, receiver, message));
        }
    }
}