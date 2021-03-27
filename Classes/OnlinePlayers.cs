using System;
using System.Collections.Generic;

namespace Parsethepapers.Classes
{
    public class OnlinePlayers
    {
        List<string> players = new List<string>();
        public OnlinePlayers(){
        }

        public void PlayerJoins(string player){
            this.players.Add(player.ToUpper());
        }

        public void PlayerLeaves(string player){
            this.players.Remove(player.ToUpper());
        }

        public string shortFor(string alias){
            alias = alias.ToUpper();
            for (int i = 0; i < this.players.Count; i++){
                if (this.players[i].Contains(alias)){
                    if (this.players[i].StartsWith(alias)){
                        return this.players[i];
                    }
                }
            }
            return "N/A";
        }
    }
}