using Act_4_2_7.Contracts;
using Act_4_2_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_4_2_7.Implementations
{
    public class TurnoRepository : ITurnoRepository
    {
        private readonly DBTurnosContext _context;
        public TurnoRepository(DBTurnosContext context)
        {
            this._context = context;
        }
        public async Task<bool> Save(TTurno turno)
        {
            if (Convert.ToDateTime(turno.Fecha) >= DateTime.Now.AddDays(1) && Convert.ToDateTime(turno.Fecha) < DateTime.Now.AddDays(45)) 
            {
                List<TDetallesTurno> detalles = _context.TDetallesTurnos.ToList();
                if (detalles.Count > 0)
                {
                    int contador = 0;
                    int comp;
                    for (int i = 0; i < detalles.Count; i++)
                    {
                        contador = 0;
                        comp = detalles[i].IdServicio;
                        if (detalles[i].IdServicio == comp)
                            contador++;
                        if (contador > 1)
                            return await _context.SaveChangesAsync() == 1;
                    }
                    List<TTurno> turnos = _context.TTurnos.ToList();
                    bool flag = true;
                    turnos.ForEach(turn =>
                    {
                        if (turn.Fecha == turno.Fecha && turn.Hora == turno.Hora) flag = false;
                    });
                    if (flag)
                    {
                        bool flag2 = false;
                        foreach(TDetallesTurno dt in detalles)
                        {
                            if (dt.IdServicio != 0)
                            {
                                flag2 = true;
                                break;
                            }
                        }
                        if (flag2)
                        {
                            await _context.TTurnos.AddAsync(turno);
                            return await _context.SaveChangesAsync() > 0;
                        }
                    }
                }
                return await _context.SaveChangesAsync() == 1;
            }
            return await _context.SaveChangesAsync() == 1;
        }
    }
}
