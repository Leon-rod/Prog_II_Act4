using Act_4_2_7.Contracts;
using Act_4_2_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_4_2_7.Implementations
{
    public class TurnoService : ITurnoService
    {
        private readonly ITurnoRepository _turnoRepository;
        public TurnoService(ITurnoRepository repository)
        {
            this._turnoRepository = repository;
        }
        public Task<bool> Save(TTurno turno)
        {
            return _turnoRepository.Save(turno);
        }
    }
}
