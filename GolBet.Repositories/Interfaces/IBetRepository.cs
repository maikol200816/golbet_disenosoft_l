using GolBet.Entities;
using GolBet.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolBet.Repositories.Interfaces;

public interface IBetRepository : IGenericRepository<Bet>

{

    /// <summary>Does this user already have this exact pick on this match?</summary> 

    Task<bool> ExistsAsync(int matchId, string userId, BetPick pick);



    /// <summary>All bets of a user, newest first, with match and teams loaded.</summary> 

    Task<IEnumerable<Bet>> GetByUserAsync(string userId);

}
