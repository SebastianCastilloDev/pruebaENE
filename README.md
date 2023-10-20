# Informe prueba ENE

# Introducción
En el marco de la solicitud de realizar una prueba de nivel nacional, se nos ha solicitado dar solución a la siguiente situacion.

Una empresa desea confeccionar un software que permita algunas operaciones de acuerdo a dos distintos roles.

* Usuario normal.
* Administrador.

El usuario normal debe poder calcular los sueldos pudiendo realizar las dos siguientes operaciones.

    - Consultar un trabajador y poder visualizar los parámetros que se requieren.
    - Modificar los parámetros de cálculo de sueldo de un trabajador.

El usuario administrador, además de las operaciones del usuario normal, debe poder 
    
    - Crear trabajadores.
    - Consultar trabajadores.
    - Actualizar trabajadores.
    - Eliminar trabajadores.

En este documento explicaremos cuales fueron los mecanismos utilizados para dar solución a la problemática.

# Desarrollo
## Arquitectura.


La arquitectura escogida consta de 3 capas, a saber, **CapaData**, **CapaNegocios**, **CapaPresentación**. Esta es una convención ampliamente adoptada por la comunidad de desarrolladores y tiene como fin, favorecer la mantenibilidad y la escalabilidad de la aplicación. Cada una de estas capas tiene una responsabilidad definida.

* **CapaData**: Se encarga de generar, almacenar y gestionar la información que alimenta a la aplicación. Para la generacion de información se utilizan arrays y listas.

* **CapaNegocios**: Se encarga de manejar la lógica propia del cálculo de sueldos.

* **CapaPresentación**: Se encarga de manejar las interacciones con el usuario, consta de un grupo de formularios y gestiona los posibles errores que puedan ocurrir.

A continuación procederemos a explicar en detalle cada uno de estos elementos:

## Capa de datos.
La capa de datos tiene el objetivo de proporcionar datos y manejar las estructuras de datos que se requieren. Para ello consta de 5 clases.


### Clase Usuario:
```csharp
 public class Usuario
    {
        public string Nombre { get; set; }
        public string PassWord { get; set; }
        public string Rol { get; set; }
        public Usuario(string nombre, string passWord, string rol)
        {
            Nombre = nombre;
            PassWord = passWord;
            Rol = rol;
        }
    }
```

### Clase Trabajador:
```csharp
    public class Trabajador
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Afp { get; set; }
        public string Salud { get; set; }
        public int HorasTrabajadas { get; set; }
        public int HorasExtra { get; set; }
        public Trabajador(string rut, string nombre, string direccion, string telefono, string afp, string salud, int horasTrabajadas, int horasExtra)
        {
            Rut = rut;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Afp = afp;
            Salud = salud;
            HorasTrabajadas = horasTrabajadas;
            HorasExtra = horasExtra;
        }
    }
```

También cuenta con un método tipo para generar trabajadores. En este caso genera valores para 5 trabajadores.

```csharp
public List<Trabajador> GenerarTrabajadores()
{
    List<Trabajador> trabajadores = new List<Trabajador>();
    for(int i=0; i < 5; i++)
    {
        trabajadores.Add(new Trabajador("rut" + i, "nombre" + i, "direccion" + i, "telefono" + i, "Modelo", "Banmedica", 10, 10));
    }
    return trabajadores;
} 
```

Finalmente contamos con 2 clases estáticas, que nos proveerán los sistemas de salud y de pensiones que tenemos disponibles.

```csharp
public static class SistemaSalud
{
    public static string[] prevision = new string[4] { "Fonasa", "Consalud", "Masvida", "Banmedica" };
}
public static class SistemaPensiones
{
    public static string[] afp = new string[4] { "Cuprum", "Modelo", "Capital", "Provida" };
}
```

## Capa negocios.
Se encarga de gestionar el cálculo de valores de sueldo bruto y sueldo líquido. Se ha configurado como una clase estática.

Contiene sólo una clase llamada **Sueldo**
Cuenta con 4 parámetros y con 4 métodos que reciben parámetros de acuerdo al cálculo que se desea efectuar, los cuales se detallarán a continuación.



```csharp
private static int valorHora = 5000;
private static int valorExtra = 7000;
private static string afp;
private static string salud;
```

```csharp
public static int SueldoBruto(int horasTrabajadas, int horasExtra) {
    int sueldoBruto = horasTrabajadas * valorHora + horasExtra * valorExtra;
    return sueldoBruto;
} 
            
```
```csharp
public static decimal DescuentoAfp(int sueldoBruto, string afp)
        {
            double descuento;
            switch (afp.ToLower())
            {
                case "cuprum":
                    descuento = 0.07;
                    break;
                case "modelo":
                    descuento = 0.09;
                    break;
                case "capital":
                    descuento = 0.12;
                    break;
                case "provida":
                    descuento = 0.13;
                    break;
                default:
                    throw new ArgumentException("Argumento incorrecto");
            }

            return sueldoBruto * (decimal)descuento;
        }            
```
```csharp
public static decimal DescuentoSalud(int sueldoBruto, string sistemaSalud)
        {
            double descuento;
            switch (sistemaSalud.ToLower())
            {
                case "fonasa":
                    descuento = 0.12;
                    break;
                case "consalud":
                    descuento = 0.13;
                    break;
                case "masvida":
                    descuento = 0.14;
                    break;
                case "banmedica":
                    descuento = 0.15;
                    break;
                default:
                    throw new ArgumentException("Argumento incorrecto");
            }

            return sueldoBruto * (decimal)descuento;
        }

            
```
```csharp
public static decimal SueldoLiquido(int horasTrabajadas, int horasExtra, string afp, string sistemaSalud)
        {
            int sueldoBruto = SueldoBruto(horasTrabajadas, horasExtra);
            return  (decimal)sueldoBruto 
                    - (decimal)DescuentoAfp(sueldoBruto, afp) 
                    - (decimal)DescuentoSalud(sueldoBruto, sistemaSalud);
        }            
```

## Capa Presentación.

La capa presentación se encarga de gestionar las interacciones con el usuario. Recordemos que tenemos dos tipos de usuarios, el usuario normal y el administrador. El ***usuario normal***, se encarga de calcular los sueldos para los empleados ingresando el numero de *horas trabajadas*, el número de *horas extra*, el *sistema de salud* y de *previsión* que tendrá el trabajador. Por otro lado, el ***usuario administrador*** se encargará de *agregar*, *consultar*, *actualizar* y *eliminar* trabajadores. También **hemos supuesto que el usuario administrador tendrá acceso a toda la aplicación**. 

Además debemos considerar la operación de autenticación que se debe llevar a cabo al momento de inicializar la aplicación. Comenzaremos nuestra exposición a partir de este punto.

### Autenticación de usuarios.

Hemos definido dos roles para nuestros usuarios: **Admin** y **Usuario**. consultaremos nuestra capa de datos para saber si existe o no un usuario. El siguiente fragmento de código, nos muestra la lógica de la operación al momento de lanzar el evento Click.

```csharp
private void btnIngresar_Click(object sender, EventArgs e)
{
    Usuario user;
    try
    {
        user = LoginUsuario();
    }
    catch (InvalidCredentialException ex)
    {
        MessageBox.Show(ex.Message, "Error de nicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
    user = null;
    }

    if (user != null) AbrirForm(user);
}
```

Note que el procedimiento incluye manejo de excepciones, en donde se invoca una instancia de la clase de excepción InvalidCredentialException.

Esto nos permitira manejar la ocurrencia de que las credenciales de acceso sean inválidas. Cuando se intenta hacer la operacion de asignar un valor a la variable user. Note que el tipo de la variable user es Usuario.

