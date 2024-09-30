using Act_4_2_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_4_2_7.Contracts
{
    public interface ITurnoRepository
    {
        Task<bool> Save(TTurno turno);

    }
}
