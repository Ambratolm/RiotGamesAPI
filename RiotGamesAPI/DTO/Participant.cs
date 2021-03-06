﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// The participant information.
    /// </summary>
    public class Participant
    {
        /// <summary>
        /// The ID of the profile icon used by this participant.
        /// </summary>
        [JsonProperty("profileIconId")]
        public long ProfileIconId { get; set; }

        /// <summary>
        /// The ID of the champion played by this participant.
        /// </summary>
        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        /// <summary>
        /// The summoner name of this participant.
        /// </summary>
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        /// <summary>
        /// Flag indicating whether or not this participant is a bot.
        /// </summary>
        [JsonProperty("bot")]
        public bool Bot { get; set; }

        /// <summary>
        /// The ID of the second summoner spell used by this participant.
        /// </summary>
        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }
        
        /// <summary>
        /// The team ID of this participant, indicating the participant's team.
        /// </summary>
        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        /// <summary>
        /// The ID of the first summoner spell used by this participant.
        /// </summary>
        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }

        public override string ToString()
        {
            return string.Format("Summoner Name : {0}{1}Champion ID : {2}", 
                SummonerName, System.Environment.NewLine, ChampionId);
        }
    }
}
