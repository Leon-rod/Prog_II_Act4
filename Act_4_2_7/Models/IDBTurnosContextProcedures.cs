﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Act_4_2_7.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Act_4_2_7.Models
{
    public partial interface IDBTurnosContextProcedures
    {
        Task<List<SP_CONSULTAR_SERVICIOSResult>> SP_CONSULTAR_SERVICIOSAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_CONTAR_TURNOSAsync(string fecha, string hora, OutputParameter<int?> ctd_turnos, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_INSERTAR_DETALLESAsync(int? id_turno, int? id_servicio, string observaciones, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
