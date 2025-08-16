using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Clases
{
	public enum Prioridad { Alta, Media, Baja}
	public class Tarea
	{
		public Guid Id { get; } = Guid.NewGuid();
		public string Nombre { get; set; } = "";

		public Prioridad Prioridad { get; set; } = Prioridad.Baja;
	}
}
