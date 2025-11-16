using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCampeonatoFutbolBE
{
    public class PartidoBE
    {
		private Guid _id;

		public Guid Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private int _golesLocalCantidad;

		public int GolesLocalCantidad
		{
			get { return _golesLocalCantidad; }
			set { _golesLocalCantidad = value; }
		}

		private int _golesVisitanteCantidad;

		public int GolesVisitanteCantidad
		{
			get { return _golesVisitanteCantidad; }
			set { _golesVisitanteCantidad = value; }
		}

		private int _expulsionesLocalCantidad;

		public int ExpulsionesLocalCantidad
		{
			get { return _expulsionesLocalCantidad; }
			set { _expulsionesLocalCantidad = value; }
		}

		private int _expulsionesVisitanteCantidad;

		public int ExpulsionesVisitanteCantidad
		{
			get { return _expulsionesVisitanteCantidad; }
			set { _expulsionesVisitanteCantidad = value; }
		}

		private List<GolBE> _golesLocal;

		public List<GolBE> GolesLocal
		{
			get { return _golesLocal; }
			set { _golesLocal = value; }
		}

		private List<GolBE> _golesVisitante;

		public List<GolBE> GolesVisitante
		{
			get { return _golesVisitante; }
			set { _golesVisitante = value; }
		}

		private List<ExpulsionBE> _expulsionesLocal;

		public List<ExpulsionBE> ExpulsionesLocal
		{
			get { return _expulsionesLocal; }
			set { _expulsionesLocal = value; }
		}

		private List<ExpulsionBE> _expulsionesVisitante;

		public List<ExpulsionBE> ExpulsionesVisitante
		{
			get { return _expulsionesVisitante; }
			set { _expulsionesVisitante = value; }
		}

		private Guid _idFecha;

		public Guid IdFecha
		{
			get { return _idFecha; }
			set { _idFecha = value; }
		}

		private DateTime _dia;

		public DateTime Dia
		{
			get { return _dia; }
			set { _dia = value; }
		}

		private TimeSpan _hora;

		public TimeSpan Hora
		{
			get { return _hora; }
			set { _hora = value; }
		}

		private string _estadio;

		public string Estadio
		{
			get { return _estadio; }
			set { _estadio = value; }
		}

		private Guid _arbitro;

		public Guid Arbitro
		{
			get { return _arbitro; }
			set { _arbitro = value; }
		}

		private Guid _local;

		public Guid Local
		{
			get { return _local; }
			set { _local = value; }
		}

		private Guid _visitante;

		public Guid Visitante
		{
			get { return _visitante; }
			set { _visitante = value; }
		}


	}
}