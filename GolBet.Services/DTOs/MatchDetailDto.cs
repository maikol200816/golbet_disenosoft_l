using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolBet.Services.DTOs
{
    public class MatchDetailDto : MatchDto

    {

        /// <summary>How many bets have been placed on this match.</summary> 

        public int TotalBets { get; set; }

    }
}
