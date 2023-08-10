using Farmacia.Models;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.DatosDB
{
    public class FarmaciaContext : DbContext
    {
        //CREAMOS LAS TABLAS
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<EmpleadoModel> Empleado { get; set; }

        public DbSet<SucursalModel> Sucursal { get; set; }

        public DbSet<ProveedorModel> Proveedor { get; set; }

        public DbSet<UsuarioModel> Usuario { get; set; }

        public DbSet<VentaModel> Venta { get; set; }

        public DbSet<RecetaModel> Receta { get; set; }

        public DbSet<DetallesventaModel> Detallesventa { get; set; }

        public DbSet<DireccionModel> Direccion { get; set; }

        public DbSet<MedicamentoModel> Medicamento { get; set; }


        //CREAMOS UN CONSTRUCTOR
        public FarmaciaContext(DbContextOptions<FarmaciaContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //SEMBRAMOS DATOS DE CLIENTE

              var ClienteModel = new ClienteModel();
               ClienteModel.Id = "1";
               ClienteModel.Nombre = "Kevin";
               ClienteModel.Apellido = "Morales";
                ClienteModel.Correo = "kevexs";
                ClienteModel.Clave = "1234";
                ClienteModel.FechaCreacion = string.Empty;
               modelBuilder.Entity<ClienteModel>().HasData(ClienteModel);



            //SEMBRAMOS DATOS DE MEDICAMENTOS

            var listaMedicamento = new List<MedicamentoModel>()
            {
                new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = "Paracetamol",
                   Descripcion = "el paracetamon o cumunmente comocido como acetaminofen es un medicamento  de propiedades anlgesocas",
                   Stock = 5,
                   FechaCreacion="",


                },

                new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = "Jarabe para la tos",
                   Descripcion = "para la tos con mucosidad se indican los jarabes mucoliticos o expectorantes",
                   Stock = 50,
                   FechaCreacion="",
                  
                },

                  new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = "Diaren",
                   Descripcion = "Usado para aliviar diareas expontaneas cuadno son causadas por bacterias",
                   Stock = 35,
                   FechaCreacion="",


                },
                    new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = "Bprex",
                   Descripcion = "Es un alergico a la buprenorfina o a cualquier de los demas componentes",
                   Stock = 10,
                   FechaCreacion="",


                },
                    new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = "Simvastatina",
                   Descripcion = "Se emplea para reducir el colesterol y los triglicéridos (tipo de grasa) en la sangre. Descubierta y desarrollada por Merck, se trata del primer medicamento con estatina que evidenció una disminución de la enfermedad cardiovascular y mortalidad",
                   Stock = 115,
                   FechaCreacion="",


                },
                    new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = " Aspirina",
                   Descripcion = "Se emplea para reducir el colesterol y los triglicéridos (tipo de grasa) en la sangre. Descubierta y desarrollada por Merck, se trata del primer medicamento con estatina que evidenció una disminución de la enfermedad cardiovascular y mortalidad",
                   Stock = 100,
                   FechaCreacion="",


                },
                    new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = "Omeprazol ",
                   Descripcion = "Este efecto reviene las úlceras y tiene un resultado curativo sobre las úlceras existentes en el esófago, estómago y duodeno. La OMS lo incluye como medicamento 'básico'.",
                   Stock = 25,
                   FechaCreacion="",


                },
                      new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = " Lexotiroxina sódica",
                   Descripcion = "Se encarga de sustituir una hormona que se suele producir en nuestra glándula tiroidea para regular la energía y el metabolismo del cuerpo.",
                   Stock = 50,
                   FechaCreacion="",


                },
                  new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = "Amlodipina",
                   Descripcion = "Este sí que está en la lista de la OMS y es un bloqueador de los canales de calcio. Ensancha los vasos sanguíneos y mejora el flujo de la sangre, por lo que se usa para reducir la presión arterial y tratar la hipertensión",
                   Stock = 30,
                   FechaCreacion="",


                },
                   new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = " Atorvastatina",
                   Descripcion = "Disminuye la cantidad de colesterol que fabrica el hígado. Sirve para reducir los niveles de trigliricéridos en sangre y colesterol 'malo', al tiempo que aumenta los niveles de colesterol 'bueno'.",
                   Stock = 45,
                   FechaCreacion="",


                },
                      new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = " Salbutamol",
                   Descripcion = "Popularmente conocido como Ventolin, se usa como prevención de broncoespasmos en pacientes con asma, bronquitis, enfisema y otras enfermedades del pulmón.",
                   Stock = 65,
                   FechaCreacion="",


                },
                         new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = " Lansoprazol",
                   Descripcion = "No está incluido en la lista de la OMS pero se encarga también de disminuir la cantidad de ácido producido en el estómago y se usa para tratar y prevenir las úlceras en este órgano y en el intestino y para controlar el ardor",
                   Stock = 55,
                   FechaCreacion="",


                },
                            new MedicamentoModel
                {
                   Id = Guid.NewGuid().ToString(),
                   Nombre = " Atorvastatina",
                   Descripcion = "Disminuye la cantidad de colesterol que fabrica el hígado. Sirve para reducir los niveles de trigliricéridos en sangre y colesterol 'malo', al tiempo que aumenta los niveles de colesterol 'bueno'.",
                   Stock = 15,
                   FechaCreacion="",


                },

            };


            modelBuilder.Entity<MedicamentoModel>().HasData(listaMedicamento);



            //SEMBRAMOS DATOS DE EMPLEADO



            var listaEmpleado = new List<EmpleadoModel>()
            {
                new EmpleadoModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "JUAN",
                   Apellido = "RAMOS",
                   Direccion = "QUITO",
                   Telefono = "0945128590",
                   Correo="juanito_09@gmail.com",
                   Cedula="1754852650",
                   FechaNacimiento="NOVIEMBRE",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="222",
                   FechaCreacion=""


                },

                new EmpleadoModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "SEBAS",
                   Apellido = "AGUIRRE",
                   Direccion = "QUITO",
                   Telefono = "0930468512",
                   Correo="sebas12@hotmail.com",
                   Cedula="1745236820",
                   FechaNacimiento="FEBRERO",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="722",
                   FechaCreacion=""
                },

                  new EmpleadoModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "ALEX",
                   Apellido = "BASTIDAS",
                   Direccion = "CARCELEN",
                   Telefono = "0985461254",
                   Correo="alexsim87@gmail.com",
                   Cedula="1745628545",
                   FechaNacimiento="ABRIL",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="111",
                   FechaCreacion=""


                },
                    new EmpleadoModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Nombre = "PABLO",
                   Apellido = "ROSAS",
                   Direccion = "La parada 7",
                   Telefono = "0985461275",
                   Correo="pablito_56@gmail.com",
                   Cedula="1754235085",
                   FechaNacimiento="MARZO",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="267",
                   FechaCreacion=""

                },
                    new EmpleadoModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Nombre = "LEON",
                   Apellido = "REYES",
                   Direccion = "PAPAYACTA",
                   Telefono = "0958423610",
                   Correo="leonisto13@gmail.com",
                   Cedula="1724859612",
                   FechaNacimiento="DICIEMBRE",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="787",
                   FechaCreacion=""

                },
                    new EmpleadoModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Nombre = "RAUL",
                   Apellido = "ZAMBRANO",
                   Direccion = "SOLANDA",
                   Telefono = "0956124350",
                   Correo="raulrogri_87@gmail.com",
                   Cedula="1734254687",
                   FechaNacimiento="SEPTIEMBRE",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="009",
                   FechaCreacion=""

                },
                    new EmpleadoModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Nombre = "MAURICIO",
                   Apellido = "RESTREPO",
                   Direccion = "COLOMBIA",
                   Telefono = "0985452310",
                   Correo="mauri_87@gmail.com",
                   Cedula="1756824320",
                   FechaNacimiento="MAYO",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="321",
                   FechaCreacion=""


                },
                      new EmpleadoModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Nombre = "GEORGE",
                   Apellido = "BOY",
                   Direccion = "LOJA",
                   Telefono = "0994512743",
                   Correo="gor_99@gmail.com",
                   Cedula="1745320582",
                   FechaNacimiento="JULIO",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="111",
                   FechaCreacion=""


                },
                  new EmpleadoModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Nombre = "AGUSTIN",
                   Apellido = "REYNOSO",
                   Direccion = "RIO",
                   Telefono = "0953124578",
                   Correo="agustin_mor09@hotmail.com",
                   Cedula="1727545723",
                   FechaNacimiento="NOVIEMBRE",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="272",
                   FechaCreacion=""


                },
                   new EmpleadoModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Nombre = "MICHAEL",
                   Apellido = "AYMARA",
                   Direccion = "GUAYAQUIL",
                   Telefono = "0980451230",
                   Correo="michaelmjx98@gmail.com",
                   Cedula="1999",
                   FechaNacimiento="JUNIO",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="345",
                   FechaCreacion=""


                },
                      new EmpleadoModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Nombre = "PEPE",
                   Apellido = "VALLEJO",
                   Direccion = "CALDERON",
                   Telefono = "0916235426",
                   Correo="pepeivan.56@hotmail.com",
                   Cedula="0991",
                   FechaNacimiento="OCTUBRE",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="378",
                   FechaCreacion=""

                },
                         new EmpleadoModel
                {


                   Id= Guid.NewGuid().ToString(),
                   Nombre = "IVAN",
                   Apellido = "CREED",
                   Direccion = "PONCIANO",
                   Telefono = "0986231574",
                   Correo="ivaned_89@hotmail.com",
                   Cedula="3321",
                   FechaNacimiento="ENERO",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="109",
                   FechaCreacion=""


                },
                            new EmpleadoModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Nombre = "DEMI",
                   Apellido = "TERAN",
                   Direccion = "URABÁ",
                   Telefono = "0945857564",
                   Correo="demi78@gmail.com",
                   Cedula="222",
                   FechaNacimiento="NOVIEMBRE",
                   IdUsuario= Guid.NewGuid().ToString(),
                   Clave="121",
                   FechaCreacion=""


                },


            };
            modelBuilder.Entity<EmpleadoModel>().HasData(listaEmpleado);




            //SEMBRAMOS DATOS DE SUCURSAL



            var listaSucursal = new List<SucursalModel>()
            {
                new SucursalModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Ubicacion = "SAN SEBASTIAN",
                   Ruc="12345",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""


                },

                new SucursalModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Ubicacion = "SAN JUAN",
                   Ruc="12234",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""
                },

                  new SucursalModel
                {
                  Id= Guid.NewGuid().ToString(),
                   Ubicacion = "MARIANITAS",
                   Ruc="98765",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""


                },
                    new SucursalModel
                {

                  Id= Guid.NewGuid().ToString(),
                   Ubicacion = "CARCELEN",
                   Ruc="52726",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""

                },
                    new SucursalModel
                {

                 Id= Guid.NewGuid().ToString(),
                   Ubicacion = "LA MARIN",
                   Ruc="92876",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""

                },
                    new SucursalModel
                {

                  Id= Guid.NewGuid().ToString(),
                   Ubicacion = "SAN AGUSTIN",
                   Ruc="11029",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""

                },
                    new SucursalModel
                {

                 Id= Guid.NewGuid().ToString(),
                   Ubicacion = "ATOCHA",
                   Ruc="22738",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""


                },
                      new SucursalModel
                {

            Id= Guid.NewGuid().ToString(),
                   Ubicacion = "EL TEJAR",
                   Ruc="77782",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""


                },
                  new SucursalModel
                {

                     Id= Guid.NewGuid().ToString(),
                   Ubicacion = "LA COLÓN",
                   Ruc="90906",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""


                },
                   new SucursalModel
                {

                    Id= Guid.NewGuid().ToString(),
                   Ubicacion = "SOLANDA",
                   Ruc="21376",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""

                },
                      new SucursalModel
                {

                   Id= Guid.NewGuid().ToString(),
                   Ubicacion = "CONDADO",
                   Ruc="88862",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""

                },
                         new SucursalModel
                {


                   Id= Guid.NewGuid().ToString(),
                   Ubicacion = "CALDERON",
                   Ruc="12304",
                   IdDireccion = Guid.NewGuid().ToString(),
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion=""

                },
                            new SucursalModel
                {

                  Id= Guid.NewGuid().ToString(),
                  Ubicacion = "CARAPUNGO",
                  Ruc="12867",
                  IdDireccion = Guid.NewGuid().ToString(),
                  IdEmpleado = Guid.NewGuid().ToString(),
                  FechaCreacion=""


                },


            };
            modelBuilder.Entity<SucursalModel>().HasData(listaSucursal);





            //SEMBRAMOS DATOS DEL PROVEEDOR



            var listaProveedor = new List<ProveedorModel>()
            {
                new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "VICENTE",
                   Telefono="09999",
                   Correo = "vicentesim_98@gmail.com",
                   Direccion = "SAN ISIDRO",
                   Ruc="77777",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="123",
                   FechaCreacion="",


                },

              new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "SAUL",
                   Telefono="0933945125",
                   Correo = "saulmafu99@hotmail.com",
                   Direccion = "SAN ROQUE",
                   Ruc="77227",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="122",
                   FechaCreacion="",


                },

               new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "JOSE",
                   Telefono="0958761248",
                   Correo = "jose99@gmail.com",
                   Direccion = "LA TOLA",
                   Ruc="39076",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="193",
                   FechaCreacion="",


                },
             new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "RAMIRO",
                   Telefono="0952164235",
                   Correo = "ramiroSebastian09@hotmal.com",
                   Direccion = "LA GASCA",
                   Ruc="88888",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="321",
                   FechaCreacion="",


                },
              new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "PAUL",
                   Telefono="0951432610",
                   Correo = "paulsimbaña11@gmail.com",
                   Direccion = "LOS RIOS",
                   Ruc="65491",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="888",
                   FechaCreacion="",


                },
           new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "LEONEL",
                   Telefono="0994512863",
                   Correo = "leonel_l09@gmail.com",
                   Direccion = "BUCARAMANGA",
                   Ruc="89293",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="345",
                   FechaCreacion="",


                },
       new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "JOSUE",
                   Telefono="0978154263",
                   Correo = "josue14@gmail.com",
                   Direccion = "BOSQUECITOS",
                   Ruc="77777",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="528",
                   FechaCreacion="",


                },
     new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "LEONIDAS",
                   Telefono="0983915866",
                   Correo = "leonitas_w1264@hotmail.com",
                   Direccion = "LA PERIMETRAL",
                   Ruc="12342",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="890",
                   FechaCreacion="",


                },
     new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "SELENA",
                   Telefono="0985421365",
                   Correo = "selena12@gmail.com",
                   Direccion = "NEVADA",
                   Ruc="90190",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="444",
                   FechaCreacion="",


                },
                    new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "BRYAN",
                   Telefono="0958714245",
                   Correo = "bryan99@gmail.com",
                   Direccion = "SAN ISIDRO",
                   Ruc="72811",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="111",
                   FechaCreacion="",


                },
                      new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "KEVIN",
                   Telefono="0958761258",
                   Correo = "wladimirmorales14@gmail.com",
                   Direccion = "SANTA MARTA",
                   Ruc="82917",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="403",
                   FechaCreacion="",


                },
                          new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "HUGO",
                   Telefono="022012404",
                   Correo = "hugo12_@hotmail.com",
                   Direccion = "SAN RAFAEL",
                   Ruc="77722",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="143",
                   FechaCreacion="",


                },
                     new ProveedorModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "APOLLO",
                   Telefono="0958761258",
                   Correo = "Apoyo@gmail.cpom",
                   Direccion = "SANTIAGO DE CHILE",
                   Ruc="79967",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Clave="297",
                   FechaCreacion="",


                },


            };
            modelBuilder.Entity<ProveedorModel>().HasData(listaProveedor);





            //SEMBRAMOS DATOS DEL USUARIO



            var listaUsuario = new List<UsuarioModel>()
            {
                new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "ALEX",
                   Clave="127",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },

              new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "JORGE",
                   Clave="141",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },

               new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "PATRICIO",
                   Clave="222",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
             new UsuarioModel
                {
                 Id= Guid.NewGuid().ToString(),
                   Nombre = "LILY",
                   Clave="333",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
              new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "DAVID",
                   Clave="728",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
           new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "SEBASTIAN",
                   Clave="777",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
       new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "DEMI",
                   Clave="122",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
     new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "JOHAN",
                   Clave="746",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
     new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "MIGUEL",
                   Clave="999",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
                    new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "GONZALO",
                   Clave="109",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
                      new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "GERSON",
                   Clave="678",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
                          new UsuarioModel
                {
                  Id= Guid.NewGuid().ToString(),
                   Nombre = "JAIRO",
                   Clave="354",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
                     new UsuarioModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Nombre = "DENNY",
                   Clave="616",
                   IdEmpleado = Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },


            };
            modelBuilder.Entity<UsuarioModel>().HasData(listaUsuario);

            //SEMBRAMOS DATOS DE LA VENTA



            var listaVenta = new List<VentaModel>()
            {
                new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "SEPTIEMBRE",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },

              new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "OCTUBRE",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },

               new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "NOVIEMBRE",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
             new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "DICIEMBRE",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
              new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "ENERO",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
           new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "FEBRERO",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
       new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "MARZO",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
     new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "ABRIL",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
     new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "MAYO",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
                    new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "JUNIO",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
                      new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "JULIO",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
                          new VentaModel
                {
                  Id= Guid.NewGuid().ToString(),
                   Fecha = "AGOSTO",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },
                     new VentaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Fecha = "SEPTIEMBRE",
                   IdCliente=Guid.NewGuid().ToString(),
                   FechaCreacion="",


                },


            };
            modelBuilder.Entity<VentaModel>().HasData(listaVenta);




            //SEMBRAMOS DATOS DE LA RECETA



            var listaReceta = new List<RecetaModel>()
            {
                new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "SEPTIEMBRE",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="12",
                   FechaCreacion="2023/08/12",


                },

              new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "OCTUBRE",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="23",
                   FechaCreacion="2023/10/01",


                },

               new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "NOVIEMBRE",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="34",
                   FechaCreacion="2023/11/01",


                },
             new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "DICIEMBRE",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="22",
                   FechaCreacion="2023/12/21",


                },
              new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "ENERO",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="83",
                   FechaCreacion="2023/01/06",


                },
           new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "FEBRERO",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="44",
                   FechaCreacion="2023/02/12",


                },
       new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "MARZO",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="64",
                   FechaCreacion="2023/03/21",


                },
     new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "ABRIL",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="10",
                   FechaCreacion="2023/04/12",


                },
     new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "MAYO",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="4",
                   FechaCreacion="2023/05/12",


                },
                    new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "JUNIO",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="8",
                   FechaCreacion="2023/06/14",


                },
                      new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "JULIO",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="29",
                   FechaCreacion="2023/07/01",


                },
                          new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "AGOSTO",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="16",
                   FechaCreacion="2023/08/14",


                },
                     new RecetaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   IdCliente= Guid.NewGuid().ToString(),
                   Fecha = "SEPTIEMBRE",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   Cantidad="42",
                   FechaCreacion="2023/09/14",


                },


            };
            modelBuilder.Entity<RecetaModel>().HasData(listaReceta);


            /// <summary>
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //SEMBRAMOS DETALLES DE VENTA



            var listaDetallesventa = new List<DetallesventaModel>()
            {
                new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Diagnostico: (Síndrome de fatiga crónica hipertensión y diabetes).\r\n\r\n1)      Bebida líquida vitaminada tres veces al día (poner marca o tipo)\r\n2)      Bentónico marca (poner la marca y/o substancia activa)\r\n3)      Insulina inyectable, de tipo (poner tipo) (aplicar una inyección de un cm después de medir el azúcar) una vez al día\r\n\r\nNo consumir alimentos altos en almidones y azucares durante una semana, y realizar actividad física ligera\r\n\r\n\r\n\r\nFuente: https://www.ejemplode.com/11-escritos/2227-ejemplo_de_receta_medica.html#ixzz874o6ukco",
                   Fecha = "SEPTIEMBRE",
                   Lugar="QUITO",
                   Cantidad="12",
                   PrecioUnitario="$21",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/02/05",


                },

              new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Diagnóstico: Cefalea tensional recurrente Medicamento(s): Doloneurobion- Forte\r\n\r\nTeme 1 Capsula cada 12 horas por 15 días.\r\n\r\nSustancia activa: Diclofenaco/Tiamina/Piridoxina/Cianocobalamina.\r\n\r\n\r\n\r\nLeer más: https://10ejemplos.com/ejemplos-de-receta-medica/#ixzz874ob3YwG",
                   Fecha = "OCTUBRE",
                   Lugar="LOJA",
                   Cantidad="2",
                   PrecioUnitario="$2",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/05/21",


                },

               new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Mantener al paciente bien hidratado: darle de beber suficientes líquidos le ayudará a evitar la deshidratación y a bajar la fiebre con la temperatura del agua ingerida\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874opOcv0",
                   Fecha = "NOVIEMBRE",
                   Lugar="GUAYAQUIL",
                   Cantidad="4",
                   PrecioUnitario="$11",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/02/12",


                },
             new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Aplicar compresas de agua fría en la frente: esto evitará que la cabeza se caliente demasiado y ayuda a reducir la temperatura elevada\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874owcDlB",
                   Fecha = "DICIEMBRE",
                   Lugar="LA TOLITA",
                   Cantidad="1",
                   PrecioUnitario="$14",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/05/25",


                },
              new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Frotar alcohol en la nuca y en los pies: este es uno de los mejores remedios para bajar la fiebre, ya que por su volatilidad ayuda a reducirla rápidamente\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874p0Zg8K",
                   Fecha = "ENERO",
                   Lugar="LA LUZ",
                   Cantidad="3",
                   PrecioUnitario="$21",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/06/12",


                },
           new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Alcanfor: uno de los mejores remedios para bajar la fiebre es diluir 7 pastillas de alcanfor en un litro de agua, empapar un paño limpio de algodón en esta mezcla y frotar el cuerpo con el trapo.\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874p8SMvh",
                   Fecha = "FEBRERO",
                   Lugar="CARCELEN",
                   Cantidad="15",
                   PrecioUnitario="$30",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/06/30",


                },
       new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Baños de agua fría: otro de los remedios para bajar la fiebre es dar al paciente baños de agua fría hasta que la temperatura baje.\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874pFB9e9",
                   Fecha = "MARZO",
                   Lugar="EL TEJAR",
                   Cantidad="2",
                   PrecioUnitario="$2,50",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/05/12",


                },
     new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Compresas con hielo: cuando la temperatura es muy elevada se pueden aplicar compresas con hielo en la cabeza y los pies para ayudar a que reduzca la temperatura.\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874pKGUmf",
                   Fecha = "ABRIL",
                   Lugar="SAN ROQUE",
                   Cantidad="4",
                   PrecioUnitario="$0,70",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/04/12",


                },
     new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Ponerle una composta de cebolla en los pies: marinar una cebolla en vinagre por 15 minutos y después ponerla en los pies del paciente atada con vendas es otro de los remedios para bajar la fiebre que funcionan bien.\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874pPuUNo",
                   Fecha = "MAYO",
                   Lugar="LA COLÓN",
                   Cantidad="9",
                   PrecioUnitario="$4",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/08/12",


                },
                    new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Raíces de Angélica: una infusión de raíces de Angélica tantas veces sea necesario es otro de los remedios para bajar la fiebre.\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874pVnsEy",
                   Fecha = "JUNIO",
                   Lugar="ZAMBISA",
                   Cantidad="8",
                   PrecioUnitario="$5",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/05/12",


                },
                      new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Infusión de canela: una infusión de canela endulzada con una cucharadita de miel varias veces hasta que baje la fiebre.\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874peCZ8A",
                   Fecha = "JULIO",
                   Lugar="RUMIPAMBA",
                   Cantidad="4",
                   PrecioUnitario="$14",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/07/09",


                },
                          new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Infusión de centaurea: esta hierba es uno de los remedios para bajar la fiebre que son muy efectivos si se utiliza como infusión varias veces al día.\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874pkHHbJ",
                   Fecha = "AGOSTO",
                   Lugar="PONCIANO ALTO",
                   Cantidad="2",
                   PrecioUnitario="$7",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/08/01",


                },
                     new DetallesventaModel
                {
                   Id= Guid.NewGuid().ToString(),
                   DetallesVenta= "Baños de agua fría: otro de los remedios para bajar la fiebre es dar al paciente baños de agua fría hasta que la temperatura baje.\r\n\r\nLeer más: https://10ejemplos.com/10-ejemplos-de-remedios-para-bajar-la-fiebre/#ixzz874q6ypgy",
                   Fecha = "SEPTIEMBRE",
                   Lugar="ZAMORA",
                   Cantidad="8",
                   PrecioUnitario="$1,75",
                   IdMedicamento=Guid.NewGuid().ToString(),
                   IdVenta=Guid.NewGuid().ToString(),
                   IdReceta=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/09/01",


                },


            };
            modelBuilder.Entity<DetallesventaModel>().HasData(listaDetallesventa);



            /// <summary>
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //SEMBRAMOS DIRECCION



            var listaDireccion = new List<DireccionModel>()
            {
                new DireccionModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Calle= "Cruz Pamba",
                   Barrio = "San Juan LoMS",
                   DireccionDomiciliaria="CaRlos Guerra paredes",
                   Provincia=" Pichinhca",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/01/02",


                },

              new DireccionModel
                {
                  Id= Guid.NewGuid().ToString(),
                   Calle= "Clemente Pulupa",
                   Barrio = "Parada 7",
                   DireccionDomiciliaria="Vicente Simbaña",
                   Provincia="Pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/02/03",


                },

               new DireccionModel
                {
                  Id= Guid.NewGuid().ToString(),
                   Calle= "Nicolas Sanguña",
                   Barrio = "La tola",
                   DireccionDomiciliaria="Calle Astudillo",
                   Provincia="Pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/03/12",


                },
             new DireccionModel
                {
              Id= Guid.NewGuid().ToString(),
                   Calle= "Fe y Alegria",
                   Barrio = "La Dolorosa",
                   DireccionDomiciliaria="Garcia Moreno",
                   Provincia="Pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/04/21",


                },
              new DireccionModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Calle= "23 de Abril",
                   Barrio = "Estacion del Inca",
                   DireccionDomiciliaria="Garcia Moreno",
                   Provincia="pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/05/12",


                },
           new DireccionModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Calle= "Vicente Simbaña",
                   Barrio = "Huaco",
                   DireccionDomiciliaria="24 de Juilo",
                   Provincia="Pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/06/15",


                },
       new DireccionModel
                {
                  Id= Guid.NewGuid().ToString(),
                   Calle= "Naciones Unidas",
                   Barrio = "El Bosque",
                   DireccionDomiciliaria="diagonal al centro comerial el Bosque",
                   Provincia="Pichincha",
                   Ciudad="`Pichincha",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/07/12",


                },
     new DireccionModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Calle= "Cruz Pamba",
                   Barrio = "La parda 7",
                   DireccionDomiciliaria="Clemente Pulupa",
                   Provincia="Pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/08/17",


                },
     new DireccionModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Calle= "Calixto Muzo",
                   Barrio = "Casa tuya",
                   DireccionDomiciliaria="12 de Julio",
                   Provincia="Pichinccha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/09/12",


                },
                    new DireccionModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Calle= "10 de Agosto",
                   Barrio = "Quito Centro",
                   DireccionDomiciliaria="av Colon",
                   Provincia="Pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/10/12",


                },
                      new DireccionModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Calle= "10 de Agosto",
                   Barrio = "la Basilica",
                   DireccionDomiciliaria="y Cristobal Colon",
                   Provincia="Pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/10/21",


                },
                          new DireccionModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Calle= "Calixto muzo",
                   Barrio = "La Tola",
                   DireccionDomiciliaria="Garciaa Moreno",
                   Provincia="Pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/11/21",


                },
                     new DireccionModel
                {
                   Id= Guid.NewGuid().ToString(),
                   Calle= "Calle Merces Simbaña",
                   Barrio = "San Juan Loma",
                   DireccionDomiciliaria="Cruz Pamba",
                   Provincia="Pichincha",
                   Ciudad="Quito",
                   Pais="Ecuador",
                   IdSucursal=Guid.NewGuid().ToString(),
                   FechaCreacion="2023/12/12",


                },


            };
            modelBuilder.Entity<DireccionModel>().HasData(listaDireccion);
        }


    }

}

