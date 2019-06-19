using Clase_22.Entidades;

public delegate void DelegadoSueldo(Empleado e, float sueldo);

public delegate void DelSueldo(EmpleadoMejorado empleadoMejorado, EmpleadoSueldoArgs args);

public enum ETipoManejador
{
  limiteSueldo,
  log,
  ambos
}
