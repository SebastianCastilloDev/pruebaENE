# Informe prueba ENE

# Contenidos

* [Introducción](#introducción)
* [Desarrollo](#desarrollo)
    * [Arquitectura](#arquitectura)
    * [Capa de datos](#capa-de-datos)
        * [Clase Usuario](#clase-usuario)
        * [Clase Trabajador](#clase-trabajador)
        * [Clase SistemaSalud y Clase SistemaPensiones](#clase-sistemasalud-y-clase-sistemapensiones)
        * [Clase Data](#clase-data)
        * [Diagrama de clases](#diagrama-de-clases)
    * [Capa Negocios](#capa-negocios)
        * [Método Sueldo Bruto](#método-sueldo-bruto)
        * [Método DescuentoAfp](#método-descuentoafp)
        * [Método DescuentoSalud](#método-descuentosalud)
        * [Diagrama de clases](#diagrama-de-clases-1)
    * [Capa Presentación](#capa-presentación)
        * [Autenticación de usuarios](#autenticación-de-usuarios)
        * [Usuario Admin](#usuario-admin)
        * [Usuario Normal](#usuario-normal)
        * [Contenedor](#contenedor)
        * [Diagrama de clases](#diagrama-de-clases-2)
* [Conclusión]

# Introducción
En el marco de la solicitud de realizar una prueba de nivel nacional, se nos ha solicitado dar solución a la siguiente situación.

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

* **CapaData**: Se encarga de generar, almacenar y gestionar la información que alimenta a la aplicación. Para la generación de información se utilizan arrays y listas.

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

También cuenta con un método tipo List para generar trabajadores. En este caso genera valores para 5 trabajadores.
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

### Clase SistemaSalud y Clase SistemaPensiones

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

### Clase Data

Es una clase enfocada en la generación de datos necesarios para el funcionamiento de la aplicación.
```csharp
    public static class Data
    {
        public static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("Usuario1", "abcd","Admin"),
            new Usuario("Usuario2", "1234","Usuario"),
            new Usuario("Usuario3","pass","Usuario")
        };

        public static List<Trabajador> trabajadores = new Trabajador().GenerarTrabajadores();
    }
```

### Diagrama de clases

En el siguiente diagrama de clases podemos apreciar la estructura general de la capa de datos.

![diagrama de clases capa de datos](/img/diagrama_clases_CapaData.png)

Puede consultar el código de la capa de datos revise el siguiente [enlace](/src/CapaData/Data.cs)
## Capa negocios.
Se encarga de gestionar el cálculo de valores de sueldo bruto y sueldo líquido. Se ha configurado como una clase estática.

Contiene sólo una clase llamada **Sueldo**.
Cuenta con 4 parámetros y con 4 métodos que reciben parámetros de acuerdo al cálculo que se desea efectuar, los cuales se detallarán a continuación.

```csharp
private static int valorHora = 5000;
private static int valorExtra = 7000;
private static string afp;
private static string salud;
```
Esta clase cuenta con 4 métodos que implementan las reglas de negocio que se nos han indicado para el cálculo de sueldos.
### Método Sueldo Bruto
```csharp
public static int SueldoBruto(int horasTrabajadas, int horasExtra) {
    int sueldoBruto = horasTrabajadas * valorHora + horasExtra * valorExtra;
    return sueldoBruto;
} 
```
### Método DescuentoAfp
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
### Método DescuentoSalud
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
### Método SueldoLiquido

```csharp
public static decimal SueldoLiquido(int horasTrabajadas, int horasExtra, string afp, string sistemaSalud)
{
    int sueldoBruto = SueldoBruto(horasTrabajadas, horasExtra);
    return  (decimal)sueldoBruto 
            - (decimal)DescuentoAfp(sueldoBruto, afp) 
            - (decimal)DescuentoSalud(sueldoBruto, sistemaSalud);
}            
```

### Diagrama de clases

En el siguiente diagrama de clases podemos apreciar la estructura general de la capa negocios. Note que en esta capa se declaran también las excepciones personalizadas para manejar la ocurrencia de errores durante el cálculo de sueldos.
![diagrama de clases capa negocios](/img/diagrama_clases_CapaNegocios.png)

Puede consultar el código de esta sección en este [enlace](/src/CapaNegocios/Sueldo.cs)  
Respecto de excepciones personalizadas desarrolladas para esta sección puede consultar este [enlace](/src/CapaNegocios/Excepciones.cs)



## Capa Presentación.

La capa presentación se encarga de gestionar las interacciones con el usuario. Recordemos que tenemos dos tipos de usuarios, el usuario normal y el administrador. El ***usuario normal***, se encarga de calcular los sueldos para los trabajadores ingresando el numero de *horas trabajadas*, el número de *horas extra*, el *sistema de salud* y de *previsión* que tendrá el trabajador. Por otro lado, el ***usuario administrador*** se encargará de *agregar*, *consultar*, *actualizar* y *eliminar* trabajadores. También **hemos supuesto que el usuario administrador tendrá acceso a toda la aplicación**. 

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

Esto nos permitirá manejar la ocurrencia de que las credenciales de acceso sean inválidas. Cuando se intenta hacer la operacion de asignar un valor a la variable user. Note que el tipo de la variable user es Usuario.

El manejo de excepciones lo continuaremos utilizando a lo largo del proyecto.

La siguiente imagen muestra la ventana y los nombres de sus elementos en la propiedad Name.

![imagen](/img/frmAutenticacion.png)

Note que solo estan resaltados en texto de color rojo los controles que nos interesa modificar su propiedad Name.
para consultar la lógica desarrollada en esta sección consulte este [archivo](/src/CapaPresentacion/frmAutenticacion.cs)

### Usuario Admin
![imagen](/img/frmTrabajadorAdmin.png)
Recordemos que existen 4 operaciones del usuario administrador que deseamos manejar. Estas opciones son las operaciones del CRUD.

* Crear
* Consultar 
* Actualizar
* Eliminar

El formulario frmTrabajadorAdmin, es el encargado de gestionar esta tarea. Para ello hemos creado el siguiente constructor, que acepta por parámetro una operación.
```csharp
public frmTrabajadorAdmin(string crud)
{
    operacion = crud;
    InitializeComponent();
}
```

Los eventos que controlaremos en este formulario son los siguientes:

    btnGuardar_Click
    cbxAfp_SelectedIndexChanged
    cbxSalud_SelectedIndexChanged
    btnCancelar_Click
    frmTrabajador_Load
    txtRut_Leave

Dentro de la clase frmTrabajadorAdmin hemos creado los siguientes campos.
```csharp
string afp;
string salud;
List<Trabajador> trabajadoresList = Data.trabajadores;
string operacion; //operaciones del crud
int indiceAEliminar;
int indiceAActualizar;
```
para consultar la lógica desarrollada en esta sección consulte este [archivo](/src/CapaPresentacion/frmTrabajadorAdmin.cs)

### Usuario Normal
El formulario encargado de gestionar las acciones del usuario normal es el siguiente.
![imagen](/img/frmTrababajadorUsuarioNormal.png)

De forma similar al formulario frmTrabajadorUsuarioNormal, este formulario tambien recibe por parámetro en su constructor la opción a ejecutar. 
```csharp
public frmTrabajadorUsuarioNormal(string operacion)
{
    InitializeComponent();
    this.operacion = operacion;
    CargarComboBoxs();
    trabajadores = Data.trabajadores;
}
```
Dentro de la clase frmTrabajadorAdmin hemos creado los siguientes campos.
```csharp
List<Trabajador> trabajadoresList = Data.trabajadores;
string operacion; //operaciones del crud
int indice;
```
Los eventos que se controlan en esta clase son los siguientes:

    frmTrabajadorUsuarioNormal_Load
    txtRut_Leave
    btnOperacion_Click
    btnCancelar_Click
    txtHorasTrabajadas_Leave
    txtHorasExtra_Leave

para consultar la lógica desarrollada en esta sección consulte este [archivo](/src/CapaPresentacion/frmTrabajadorUsuarioNormal.cs)

### Contenedor

Para dar una mejor experiencia de usuario se ha decidido montar los formularios anteriores en un control de tipo Panel para poder utilizarlo de contenedor en conjunto con un control de tipo DataGridView. El diseño del formulario se ve reflejado en la siguiente imagen.

![contenedor](/img/contenedor.png)

Si observamos tenemos un control de tipo Menu Strip. que contiene dos menús. Las dos imágenes siguientes muestran los elementos de estos menús.

![administradorMenu](/img/administradorMenu.png)
![usuarioNormalMenu](/img/usuarioNormalMenu.png)

Cuenta con los siguientes campos:

    private List<string> crud = new List<string> { "Agregar", "Consultar","Actualizar","Eliminar" };
    private List<Trabajador> trabajadores;
    private static Usuario usuarioActual;
    private static ToolStripMenuItem menuActivo = null;
    private static Form formularioActivo = null;

Tiene el siguiente constructor: El parámetro usuario es enviado desde el formulario de autenticación.
```csharp
public frmContenedor(Usuario usuario)
{
    usuarioActual = usuario;
    InitializeComponent();
}
```

Y se gestionan los siguientes eventos:

    frmContenedor_Load
    btnRecargar_Click
    salirToolStripMenuItem_Click
    agregarTrabajadorToolStripMenuItem_Click
    consultarTrabajadorToolStripMenuItem_Click
    actualizarTrabajadorToolStripMenuItem_Click
    eliminarTrabajadorToolStripMenuItem_Click
    consultarTrabajadorToolStripMenuItem1_Click
    editarTrabajadorToolStripMenuItem_Click

### Diagrama de clases

El siguiente diagrama de clases muestra la estructura general de la capa de presentación.

![diagrama de clases capa presentacion](/img/diagrama_clases_CapaPresentacion.png)

la lógica que se desarrolla en este formulario se encuentra en este [archivo](/src/CapaPresentacion/frmContenedor.cs)

# Conclusión.

Se ha desarrollado una aplicación Windows Forms, con el lenguaje de programación C#. Para ello se han utilizado conceptos de programación orientada a objetos. También hemos utilizado el diseñador de formularios de Visual Studio para conseguir el producto final.

La aplicación básicamente realiza las operaciones CRUD con los registros de un grupo de trabajadores. Para cada trabajador se va a requerir calcular su sueldo bruto y su sueldo líquido. Para ello almacenamos los siguientes datos: horas trabajadas, horas extra, previsión de salud, administradora de pensiones. Estos elementos se han configurado como clases dentro del proyecto.

La aplicación administra la interacción con el usuario desde un grupo de ventanas conocidos como Windows Forms. En este grupo, se verificará que tipo de dato se está ingresando y que estos datos sean ingresados en forma correcta, para este efecto, se ha implementado el control de excepciones. 
