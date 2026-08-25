using EmpleadosApp.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmpleadosApp.Server.Context
{
    public class EmpleadosDbContext: DbContext
    {
        public EmpleadosDbContext(DbContextOptions<EmpleadosDbContext> options) : base(options)

        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // DEPARTAMENTOS
            builder.Entity<Departamento>().HasData(
                new Departamento { Id = 1, Nombre = "Recursos Humanos" },
                new Departamento { Id = 2, Nombre = "Tecnologías de la Información" },
                new Departamento { Id = 3, Nombre = "Finanzas" },
                new Departamento { Id = 4, Nombre = "Ventas" },
                new Departamento { Id = 5, Nombre = "Operaciones" }
            );

            // PUESTOS
            builder.Entity<Puesto>().HasData(
                new Puesto { Id = 1, Nombre = "Gerente" },
                new Puesto { Id = 2, Nombre = "Supervisor" },
                new Puesto { Id = 3, Nombre = "Desarrollador" },
                new Puesto { Id = 4, Nombre = "Analista" },
                new Puesto { Id = 5, Nombre = "Asistente" }
            );

            // USUARIOS
            builder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nombre = "Juan Pérez" },
                new Usuario { Id = 2, Nombre = "María López" },
                new Usuario { Id = 3, Nombre = "Carlos García" },
                new Usuario { Id = 4, Nombre = "Ana Martínez" },
                new Usuario { Id = 5, Nombre = "Luis Hernández" },
                new Usuario { Id = 6, Nombre = "Pedro González" },
                new Usuario { Id = 7, Nombre = "Laura Ramírez" },
                new Usuario { Id = 8, Nombre = "José Torres" },
                new Usuario { Id = 9, Nombre = "Sofía Flores" },
                new Usuario { Id = 10, Nombre = "Miguel Sánchez" },
                new Usuario { Id = 11, Nombre = "Daniel Rodríguez" },
                new Usuario { Id = 12, Nombre = "Fernanda Cruz" },
                new Usuario { Id = 13, Nombre = "Ricardo Morales" },
                new Usuario { Id = 14, Nombre = "Gabriela Ortiz" },
                new Usuario { Id = 15, Nombre = "Alejandro Vargas" },
                new Usuario { Id = 16, Nombre = "Patricia Mendoza" },
                new Usuario { Id = 17, Nombre = "Roberto Castro" },
                new Usuario { Id = 18, Nombre = "Andrea Ruiz" },
                new Usuario { Id = 19, Nombre = "Jorge Navarro" },
                new Usuario { Id = 20, Nombre = "Diana Reyes" },
                new Usuario { Id = 21, Nombre = "Eduardo Jiménez" },
                new Usuario { Id = 22, Nombre = "Claudia Moreno" },
                new Usuario { Id = 23, Nombre = "Francisco Silva" },
                new Usuario { Id = 24, Nombre = "Mónica Ríos" },
                new Usuario { Id = 25, Nombre = "Héctor Guerrero" },
                new Usuario { Id = 26, Nombre = "Natalia Medina" },
                new Usuario { Id = 27, Nombre = "Sergio Peña" },
                new Usuario { Id = 28, Nombre = "Valeria Campos" },
                new Usuario { Id = 29, Nombre = "Oscar Fuentes" },
                new Usuario { Id = 30, Nombre = "Regina Cabrera" },
                new Usuario { Id = 31, Nombre = "Arturo León" },
                new Usuario { Id = 32, Nombre = "Mariana Soto" },
                new Usuario { Id = 33, Nombre = "Enrique Paredes" },
                new Usuario { Id = 34, Nombre = "Lucía Velázquez" },
                new Usuario { Id = 35, Nombre = "Alberto Márquez" },
                new Usuario { Id = 36, Nombre = "Camila Espinoza" },
                new Usuario { Id = 37, Nombre = "Martín Salazar" },
                new Usuario { Id = 38, Nombre = "Alejandra Núñez" },
                new Usuario { Id = 39, Nombre = "Gustavo Acosta" },
                new Usuario { Id = 40, Nombre = "Paola Miranda" },
                new Usuario { Id = 41, Nombre = "Manuel Rojas" },
                new Usuario { Id = 42, Nombre = "Elena Valdez" },
                new Usuario { Id = 43, Nombre = "Rafael Lozano" },
                new Usuario { Id = 44, Nombre = "Silvia Ibarra" },
                new Usuario { Id = 45, Nombre = "Tomás Estrada" },
                new Usuario { Id = 46, Nombre = "Verónica Ponce" },
                new Usuario { Id = 47, Nombre = "Javier Beltrán" },
                new Usuario { Id = 48, Nombre = "Carolina Orozco" },
                new Usuario { Id = 49, Nombre = "Raúl Domínguez" },
                new Usuario { Id = 50, Nombre = "Beatriz Carrillo" },
                new Usuario { Id = 51, Nombre = "Iván Miranda" },
                new Usuario { Id = 52, Nombre = "Melissa Aguirre" },
                new Usuario { Id = 53, Nombre = "Mauricio Valencia" },
                new Usuario { Id = 54, Nombre = "Adriana Nieto" },
                new Usuario { Id = 55, Nombre = "Salvador Zamora" },
                new Usuario { Id = 56, Nombre = "Karen Castañeda" },
                new Usuario { Id = 57, Nombre = "Víctor Rocha" },
                new Usuario { Id = 58, Nombre = "Isabel Franco" },
                new Usuario { Id = 59, Nombre = "Gerardo Solís" },
                new Usuario { Id = 60, Nombre = "Renata Márquez" },
                new Usuario { Id = 61, Nombre = "Cristian Luna" },
                new Usuario { Id = 62, Nombre = "Paulina Rosales" },
                new Usuario { Id = 63, Nombre = "Esteban Valencia" },
                new Usuario { Id = 64, Nombre = "Jimena Padilla" },
                new Usuario { Id = 65, Nombre = "Ángel Miranda" },
                new Usuario { Id = 66, Nombre = "Fabiola Sandoval" },
                new Usuario { Id = 67, Nombre = "Rodrigo Mejía" },
                new Usuario { Id = 68, Nombre = "Cecilia Bravo" },
                new Usuario { Id = 69, Nombre = "Nicolás Ortega" },
                new Usuario { Id = 70, Nombre = "Teresa Salgado" },
                new Usuario { Id = 71, Nombre = "Emiliano Lara" },
                new Usuario { Id = 72, Nombre = "Bárbara Cortés" },
                new Usuario { Id = 73, Nombre = "Adrián Villanueva" },
                new Usuario { Id = 74, Nombre = "Lorena Cárdenas" },
                new Usuario { Id = 75, Nombre = "Diego Valenzuela" },
                new Usuario { Id = 76, Nombre = "Montserrat Arias" },
                new Usuario { Id = 77, Nombre = "Jesús Rangel" },
                new Usuario { Id = 78, Nombre = "Marisol Bautista" },
                new Usuario { Id = 79, Nombre = "Ignacio Franco" },
                new Usuario { Id = 80, Nombre = "Ximena Escobar" },
                new Usuario { Id = 81, Nombre = "Bruno Serrano" },
                new Usuario { Id = 82, Nombre = "Regina Maldonado" },
                new Usuario { Id = 83, Nombre = "Mateo Delgado" },
                new Usuario { Id = 84, Nombre = "Elisa Rosas" },
                new Usuario { Id = 85, Nombre = "Leonardo Miranda" },
                new Usuario { Id = 86, Nombre = "Daniela Nieto" },
                new Usuario { Id = 87, Nombre = "Pablo Cisneros" },
                new Usuario { Id = 88, Nombre = "Sara Coronado" },
                new Usuario { Id = 89, Nombre = "Fernando Olivares" },
                new Usuario { Id = 90, Nombre = "Natalia Rosales" },
                new Usuario { Id = 91, Nombre = "Marco Antonio Ruiz" },
                new Usuario { Id = 92, Nombre = "Julia Medina" },
                new Usuario { Id = 93, Nombre = "Ramón Cabrera" },
                new Usuario { Id = 94, Nombre = "Estefanía León" },
                new Usuario { Id = 95, Nombre = "Guillermo Ríos" },
                new Usuario { Id = 96, Nombre = "Abril Hernández" },
                new Usuario { Id = 97, Nombre = "Samuel Pacheco" },
                new Usuario { Id = 98, Nombre = "Rosa Elena Vargas" },
                new Usuario { Id = 99, Nombre = "César Montoya" },
                new Usuario { Id = 100, Nombre = "Karla Méndez" }
            );

            // EMPLEADOS
            builder.Entity<Empleado>().HasData(
                new Empleado { Id = 1, Nombre = "Juan Pérez", Activo = true, PuestoId = 1, DepartamentoId = 1, UsuarioId = 1 },
                new Empleado { Id = 2, Nombre = "María López", Activo = true, PuestoId = 2, DepartamentoId = 2, UsuarioId = 2 },
                new Empleado { Id = 3, Nombre = "Carlos García", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 3 },
                new Empleado { Id = 4, Nombre = "Ana Martínez", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 4 },
                new Empleado { Id = 5, Nombre = "Luis Hernández", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 5 },
                new Empleado { Id = 6, Nombre = "Pedro González", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 6 },
                new Empleado { Id = 7, Nombre = "Laura Ramírez", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 7 },
                new Empleado { Id = 8, Nombre = "José Torres", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 8 },
                new Empleado { Id = 9, Nombre = "Sofía Flores", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 9 },
                new Empleado { Id = 10, Nombre = "Miguel Sánchez", Activo = true, PuestoId = 2, DepartamentoId = 5, UsuarioId = 10 },

                new Empleado { Id = 11, Nombre = "Daniel Rodríguez", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 11 },
                new Empleado { Id = 12, Nombre = "Fernanda Cruz", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 12 },
                new Empleado { Id = 13, Nombre = "Ricardo Morales", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 13 },
                new Empleado { Id = 14, Nombre = "Gabriela Ortiz", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 14 },
                new Empleado { Id = 15, Nombre = "Alejandro Vargas", Activo = true, PuestoId = 2, DepartamentoId = 1, UsuarioId = 15 },
                new Empleado { Id = 16, Nombre = "Patricia Mendoza", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 16 },
                new Empleado { Id = 17, Nombre = "Roberto Castro", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 17 },
                new Empleado { Id = 18, Nombre = "Andrea Ruiz", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 18 },
                new Empleado { Id = 19, Nombre = "Jorge Navarro", Activo = true, PuestoId = 4, DepartamentoId = 4, UsuarioId = 19 },
                new Empleado { Id = 20, Nombre = "Diana Reyes", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 20 },

                new Empleado { Id = 21, Nombre = "Eduardo Jiménez", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 21 },
                new Empleado { Id = 22, Nombre = "Claudia Moreno", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 22 },
                new Empleado { Id = 23, Nombre = "Francisco Silva", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 23 },
                new Empleado { Id = 24, Nombre = "Mónica Ríos", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 24 },
                new Empleado { Id = 25, Nombre = "Héctor Guerrero", Activo = true, PuestoId = 2, DepartamentoId = 5, UsuarioId = 25 },
                new Empleado { Id = 26, Nombre = "Natalia Medina", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 26 },
                new Empleado { Id = 27, Nombre = "Sergio Peña", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 27 },
                new Empleado { Id = 28, Nombre = "Valeria Campos", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 28 },
                new Empleado { Id = 29, Nombre = "Oscar Fuentes", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 29 },
                new Empleado { Id = 30, Nombre = "Regina Cabrera", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 30 },

                new Empleado { Id = 31, Nombre = "Arturo León", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 31 },
                new Empleado { Id = 32, Nombre = "Mariana Soto", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 32 },
                new Empleado { Id = 33, Nombre = "Enrique Paredes", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 33 },
                new Empleado { Id = 34, Nombre = "Lucía Velázquez", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 34 },
                new Empleado { Id = 35, Nombre = "Alberto Márquez", Activo = true, PuestoId = 2, DepartamentoId = 5, UsuarioId = 35 },
                new Empleado { Id = 36, Nombre = "Camila Espinoza", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 36 },
                new Empleado { Id = 37, Nombre = "Martín Salazar", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 37 },
                new Empleado { Id = 38, Nombre = "Alejandra Núñez", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 38 },
                new Empleado { Id = 39, Nombre = "Gustavo Acosta", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 39 },
                new Empleado { Id = 40, Nombre = "Paola Miranda", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 40 },

                new Empleado { Id = 41, Nombre = "Manuel Rojas", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 41 },
                new Empleado { Id = 42, Nombre = "Elena Valdez", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 42 },
                new Empleado { Id = 43, Nombre = "Rafael Lozano", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 43 },
                new Empleado { Id = 44, Nombre = "Silvia Ibarra", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 44 },
                new Empleado { Id = 45, Nombre = "Tomás Estrada", Activo = true, PuestoId = 2, DepartamentoId = 5, UsuarioId = 45 },
                new Empleado { Id = 46, Nombre = "Verónica Ponce", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 46 },
                new Empleado { Id = 47, Nombre = "Javier Beltrán", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 47 },
                new Empleado { Id = 48, Nombre = "Carolina Orozco", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 48 },
                new Empleado { Id = 49, Nombre = "Raúl Domínguez", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 49 },
                new Empleado { Id = 50, Nombre = "Beatriz Carrillo", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 50 },

                new Empleado { Id = 51, Nombre = "Iván Miranda", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 51 },
                new Empleado { Id = 52, Nombre = "Melissa Aguirre", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 52 },
                new Empleado { Id = 53, Nombre = "Mauricio Valencia", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 53 },
                new Empleado { Id = 54, Nombre = "Adriana Nieto", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 54 },
                new Empleado { Id = 55, Nombre = "Salvador Zamora", Activo = true, PuestoId = 2, DepartamentoId = 5, UsuarioId = 55 },
                new Empleado { Id = 56, Nombre = "Karen Castañeda", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 56 },
                new Empleado { Id = 57, Nombre = "Víctor Rocha", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 57 },
                new Empleado { Id = 58, Nombre = "Isabel Franco", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 58 },
                new Empleado { Id = 59, Nombre = "Gerardo Solís", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 59 },
                new Empleado { Id = 60, Nombre = "Renata Márquez", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 60 },

                new Empleado { Id = 61, Nombre = "Cristian Luna", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 61 },
                new Empleado { Id = 62, Nombre = "Paulina Rosales", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 62 },
                new Empleado { Id = 63, Nombre = "Esteban Valencia", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 63 },
                new Empleado { Id = 64, Nombre = "Jimena Padilla", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 64 },
                new Empleado { Id = 65, Nombre = "Ángel Miranda", Activo = true, PuestoId = 2, DepartamentoId = 5, UsuarioId = 65 },
                new Empleado { Id = 66, Nombre = "Fabiola Sandoval", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 66 },
                new Empleado { Id = 67, Nombre = "Rodrigo Mejía", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 67 },
                new Empleado { Id = 68, Nombre = "Cecilia Bravo", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 68 },
                new Empleado { Id = 69, Nombre = "Nicolás Ortega", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 69 },
                new Empleado { Id = 70, Nombre = "Teresa Salgado", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 70 },

                new Empleado { Id = 71, Nombre = "Emiliano Lara", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 71 },
                new Empleado { Id = 72, Nombre = "Bárbara Cortés", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 72 },
                new Empleado { Id = 73, Nombre = "Adrián Villanueva", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 73 },
                new Empleado { Id = 74, Nombre = "Lorena Cárdenas", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 74 },
                new Empleado { Id = 75, Nombre = "Diego Valenzuela", Activo = true, PuestoId = 2, DepartamentoId = 5, UsuarioId = 75 },
                new Empleado { Id = 76, Nombre = "Montserrat Arias", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 76 },
                new Empleado { Id = 77, Nombre = "Jesús Rangel", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 77 },
                new Empleado { Id = 78, Nombre = "Marisol Bautista", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 78 },
                new Empleado { Id = 79, Nombre = "Ignacio Franco", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 79 },
                new Empleado { Id = 80, Nombre = "Ximena Escobar", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 80 },

                new Empleado { Id = 81, Nombre = "Bruno Serrano", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 81 },
                new Empleado { Id = 82, Nombre = "Regina Maldonado", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 82 },
                new Empleado { Id = 83, Nombre = "Mateo Delgado", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 83 },
                new Empleado { Id = 84, Nombre = "Elisa Rosas", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 84 },
                new Empleado { Id = 85, Nombre = "Leonardo Miranda", Activo = true, PuestoId = 2, DepartamentoId = 5, UsuarioId = 85 },
                new Empleado { Id = 86, Nombre = "Daniela Nieto", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 86 },
                new Empleado { Id = 87, Nombre = "Pablo Cisneros", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 87 },
                new Empleado { Id = 88, Nombre = "Sara Coronado", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 88 },
                new Empleado { Id = 89, Nombre = "Fernando Olivares", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 89 },
                new Empleado { Id = 90, Nombre = "Natalia Rosales", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 90 },

                new Empleado { Id = 91, Nombre = "Marco Antonio Ruiz", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 91 },
                new Empleado { Id = 92, Nombre = "Julia Medina", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 92 },
                new Empleado { Id = 93, Nombre = "Ramón Cabrera", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 93 },
                new Empleado { Id = 94, Nombre = "Estefanía León", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 94 },
                new Empleado { Id = 95, Nombre = "Guillermo Ríos", Activo = true, PuestoId = 2, DepartamentoId = 5, UsuarioId = 95 },
                new Empleado { Id = 96, Nombre = "Abril Hernández", Activo = true, PuestoId = 4, DepartamentoId = 1, UsuarioId = 96 },
                new Empleado { Id = 97, Nombre = "Samuel Pacheco", Activo = true, PuestoId = 5, DepartamentoId = 4, UsuarioId = 97 },
                new Empleado { Id = 98, Nombre = "Rosa Elena Vargas", Activo = true, PuestoId = 3, DepartamentoId = 2, UsuarioId = 98 },
                new Empleado { Id = 99, Nombre = "César Montoya", Activo = true, PuestoId = 4, DepartamentoId = 3, UsuarioId = 99 },
                new Empleado { Id = 100, Nombre = "Karla Méndez", Activo = true, PuestoId = 5, DepartamentoId = 5, UsuarioId = 100 }
            );
        }


        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<Empleado> Empleados {  get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



    }
}
