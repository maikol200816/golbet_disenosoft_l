using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolBet.Services.DTOs;

public class ResolutionSummaryDto

{

    public int ResolvedBets { get; set; }

    public int WonBets { get; set; }

    public decimal TotalPaid { get; set; }

}
