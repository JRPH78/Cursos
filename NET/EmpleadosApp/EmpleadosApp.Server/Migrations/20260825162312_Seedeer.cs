using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpleadosApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seedeer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Usuario_UsuarioId",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Recursos Humanos" },
                    { 2, "Tecnologías de la Información" },
                    { 3, "Finanzas" },
                    { 4, "Ventas" },
                    { 5, "Operaciones" }
                });

            migrationBuilder.InsertData(
                table: "Puestos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Gerente" },
                    { 2, "Supervisor" },
                    { 3, "Desarrollador" },
                    { 4, "Analista" },
                    { 5, "Asistente" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Juan Pérez" },
                    { 2, "María López" },
                    { 3, "Carlos García" },
                    { 4, "Ana Martínez" },
                    { 5, "Luis Hernández" },
                    { 6, "Pedro González" },
                    { 7, "Laura Ramírez" },
                    { 8, "José Torres" },
                    { 9, "Sofía Flores" },
                    { 10, "Miguel Sánchez" },
                    { 11, "Daniel Rodríguez" },
                    { 12, "Fernanda Cruz" },
                    { 13, "Ricardo Morales" },
                    { 14, "Gabriela Ortiz" },
                    { 15, "Alejandro Vargas" },
                    { 16, "Patricia Mendoza" },
                    { 17, "Roberto Castro" },
                    { 18, "Andrea Ruiz" },
                    { 19, "Jorge Navarro" },
                    { 20, "Diana Reyes" },
                    { 21, "Eduardo Jiménez" },
                    { 22, "Claudia Moreno" },
                    { 23, "Francisco Silva" },
                    { 24, "Mónica Ríos" },
                    { 25, "Héctor Guerrero" },
                    { 26, "Natalia Medina" },
                    { 27, "Sergio Peña" },
                    { 28, "Valeria Campos" },
                    { 29, "Oscar Fuentes" },
                    { 30, "Regina Cabrera" },
                    { 31, "Arturo León" },
                    { 32, "Mariana Soto" },
                    { 33, "Enrique Paredes" },
                    { 34, "Lucía Velázquez" },
                    { 35, "Alberto Márquez" },
                    { 36, "Camila Espinoza" },
                    { 37, "Martín Salazar" },
                    { 38, "Alejandra Núñez" },
                    { 39, "Gustavo Acosta" },
                    { 40, "Paola Miranda" },
                    { 41, "Manuel Rojas" },
                    { 42, "Elena Valdez" },
                    { 43, "Rafael Lozano" },
                    { 44, "Silvia Ibarra" },
                    { 45, "Tomás Estrada" },
                    { 46, "Verónica Ponce" },
                    { 47, "Javier Beltrán" },
                    { 48, "Carolina Orozco" },
                    { 49, "Raúl Domínguez" },
                    { 50, "Beatriz Carrillo" },
                    { 51, "Iván Miranda" },
                    { 52, "Melissa Aguirre" },
                    { 53, "Mauricio Valencia" },
                    { 54, "Adriana Nieto" },
                    { 55, "Salvador Zamora" },
                    { 56, "Karen Castañeda" },
                    { 57, "Víctor Rocha" },
                    { 58, "Isabel Franco" },
                    { 59, "Gerardo Solís" },
                    { 60, "Renata Márquez" },
                    { 61, "Cristian Luna" },
                    { 62, "Paulina Rosales" },
                    { 63, "Esteban Valencia" },
                    { 64, "Jimena Padilla" },
                    { 65, "Ángel Miranda" },
                    { 66, "Fabiola Sandoval" },
                    { 67, "Rodrigo Mejía" },
                    { 68, "Cecilia Bravo" },
                    { 69, "Nicolás Ortega" },
                    { 70, "Teresa Salgado" },
                    { 71, "Emiliano Lara" },
                    { 72, "Bárbara Cortés" },
                    { 73, "Adrián Villanueva" },
                    { 74, "Lorena Cárdenas" },
                    { 75, "Diego Valenzuela" },
                    { 76, "Montserrat Arias" },
                    { 77, "Jesús Rangel" },
                    { 78, "Marisol Bautista" },
                    { 79, "Ignacio Franco" },
                    { 80, "Ximena Escobar" },
                    { 81, "Bruno Serrano" },
                    { 82, "Regina Maldonado" },
                    { 83, "Mateo Delgado" },
                    { 84, "Elisa Rosas" },
                    { 85, "Leonardo Miranda" },
                    { 86, "Daniela Nieto" },
                    { 87, "Pablo Cisneros" },
                    { 88, "Sara Coronado" },
                    { 89, "Fernando Olivares" },
                    { 90, "Natalia Rosales" },
                    { 91, "Marco Antonio Ruiz" },
                    { 92, "Julia Medina" },
                    { 93, "Ramón Cabrera" },
                    { 94, "Estefanía León" },
                    { 95, "Guillermo Ríos" },
                    { 96, "Abril Hernández" },
                    { 97, "Samuel Pacheco" },
                    { 98, "Rosa Elena Vargas" },
                    { 99, "César Montoya" },
                    { 100, "Karla Méndez" }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Activo", "DepartamentoId", "Nombre", "PuestoId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, true, 1, "Juan Pérez", 1, 1 },
                    { 2, true, 2, "María López", 2, 2 },
                    { 3, true, 2, "Carlos García", 3, 3 },
                    { 4, true, 3, "Ana Martínez", 4, 4 },
                    { 5, true, 4, "Luis Hernández", 5, 5 },
                    { 6, true, 2, "Pedro González", 3, 6 },
                    { 7, true, 1, "Laura Ramírez", 4, 7 },
                    { 8, true, 5, "José Torres", 5, 8 },
                    { 9, true, 2, "Sofía Flores", 3, 9 },
                    { 10, true, 5, "Miguel Sánchez", 2, 10 },
                    { 11, true, 2, "Daniel Rodríguez", 3, 11 },
                    { 12, true, 3, "Fernanda Cruz", 4, 12 },
                    { 13, true, 4, "Ricardo Morales", 5, 13 },
                    { 14, true, 2, "Gabriela Ortiz", 3, 14 },
                    { 15, true, 1, "Alejandro Vargas", 2, 15 },
                    { 16, true, 3, "Patricia Mendoza", 4, 16 },
                    { 17, true, 5, "Roberto Castro", 5, 17 },
                    { 18, true, 2, "Andrea Ruiz", 3, 18 },
                    { 19, true, 4, "Jorge Navarro", 4, 19 },
                    { 20, true, 5, "Diana Reyes", 5, 20 },
                    { 21, true, 2, "Eduardo Jiménez", 3, 21 },
                    { 22, true, 1, "Claudia Moreno", 4, 22 },
                    { 23, true, 4, "Francisco Silva", 5, 23 },
                    { 24, true, 2, "Mónica Ríos", 3, 24 },
                    { 25, true, 5, "Héctor Guerrero", 2, 25 },
                    { 26, true, 3, "Natalia Medina", 4, 26 },
                    { 27, true, 4, "Sergio Peña", 5, 27 },
                    { 28, true, 2, "Valeria Campos", 3, 28 },
                    { 29, true, 1, "Oscar Fuentes", 4, 29 },
                    { 30, true, 5, "Regina Cabrera", 5, 30 },
                    { 31, true, 2, "Arturo León", 3, 31 },
                    { 32, true, 3, "Mariana Soto", 4, 32 },
                    { 33, true, 4, "Enrique Paredes", 5, 33 },
                    { 34, true, 2, "Lucía Velázquez", 3, 34 },
                    { 35, true, 5, "Alberto Márquez", 2, 35 },
                    { 36, true, 1, "Camila Espinoza", 4, 36 },
                    { 37, true, 4, "Martín Salazar", 5, 37 },
                    { 38, true, 2, "Alejandra Núñez", 3, 38 },
                    { 39, true, 3, "Gustavo Acosta", 4, 39 },
                    { 40, true, 5, "Paola Miranda", 5, 40 },
                    { 41, true, 2, "Manuel Rojas", 3, 41 },
                    { 42, true, 1, "Elena Valdez", 4, 42 },
                    { 43, true, 4, "Rafael Lozano", 5, 43 },
                    { 44, true, 2, "Silvia Ibarra", 3, 44 },
                    { 45, true, 5, "Tomás Estrada", 2, 45 },
                    { 46, true, 3, "Verónica Ponce", 4, 46 },
                    { 47, true, 4, "Javier Beltrán", 5, 47 },
                    { 48, true, 2, "Carolina Orozco", 3, 48 },
                    { 49, true, 1, "Raúl Domínguez", 4, 49 },
                    { 50, true, 5, "Beatriz Carrillo", 5, 50 },
                    { 51, true, 2, "Iván Miranda", 3, 51 },
                    { 52, true, 3, "Melissa Aguirre", 4, 52 },
                    { 53, true, 4, "Mauricio Valencia", 5, 53 },
                    { 54, true, 2, "Adriana Nieto", 3, 54 },
                    { 55, true, 5, "Salvador Zamora", 2, 55 },
                    { 56, true, 1, "Karen Castañeda", 4, 56 },
                    { 57, true, 4, "Víctor Rocha", 5, 57 },
                    { 58, true, 2, "Isabel Franco", 3, 58 },
                    { 59, true, 3, "Gerardo Solís", 4, 59 },
                    { 60, true, 5, "Renata Márquez", 5, 60 },
                    { 61, true, 2, "Cristian Luna", 3, 61 },
                    { 62, true, 1, "Paulina Rosales", 4, 62 },
                    { 63, true, 4, "Esteban Valencia", 5, 63 },
                    { 64, true, 2, "Jimena Padilla", 3, 64 },
                    { 65, true, 5, "Ángel Miranda", 2, 65 },
                    { 66, true, 3, "Fabiola Sandoval", 4, 66 },
                    { 67, true, 4, "Rodrigo Mejía", 5, 67 },
                    { 68, true, 2, "Cecilia Bravo", 3, 68 },
                    { 69, true, 1, "Nicolás Ortega", 4, 69 },
                    { 70, true, 5, "Teresa Salgado", 5, 70 },
                    { 71, true, 2, "Emiliano Lara", 3, 71 },
                    { 72, true, 3, "Bárbara Cortés", 4, 72 },
                    { 73, true, 4, "Adrián Villanueva", 5, 73 },
                    { 74, true, 2, "Lorena Cárdenas", 3, 74 },
                    { 75, true, 5, "Diego Valenzuela", 2, 75 },
                    { 76, true, 1, "Montserrat Arias", 4, 76 },
                    { 77, true, 4, "Jesús Rangel", 5, 77 },
                    { 78, true, 2, "Marisol Bautista", 3, 78 },
                    { 79, true, 3, "Ignacio Franco", 4, 79 },
                    { 80, true, 5, "Ximena Escobar", 5, 80 },
                    { 81, true, 2, "Bruno Serrano", 3, 81 },
                    { 82, true, 1, "Regina Maldonado", 4, 82 },
                    { 83, true, 4, "Mateo Delgado", 5, 83 },
                    { 84, true, 2, "Elisa Rosas", 3, 84 },
                    { 85, true, 5, "Leonardo Miranda", 2, 85 },
                    { 86, true, 3, "Daniela Nieto", 4, 86 },
                    { 87, true, 4, "Pablo Cisneros", 5, 87 },
                    { 88, true, 2, "Sara Coronado", 3, 88 },
                    { 89, true, 1, "Fernando Olivares", 4, 89 },
                    { 90, true, 5, "Natalia Rosales", 5, 90 },
                    { 91, true, 2, "Marco Antonio Ruiz", 3, 91 },
                    { 92, true, 3, "Julia Medina", 4, 92 },
                    { 93, true, 4, "Ramón Cabrera", 5, 93 },
                    { 94, true, 2, "Estefanía León", 3, 94 },
                    { 95, true, 5, "Guillermo Ríos", 2, 95 },
                    { 96, true, 1, "Abril Hernández", 4, 96 },
                    { 97, true, 4, "Samuel Pacheco", 5, 97 },
                    { 98, true, 2, "Rosa Elena Vargas", 3, 98 },
                    { 99, true, 3, "César Montoya", 4, 99 },
                    { 100, true, 5, "Karla Méndez", 5, 100 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Usuarios_UsuarioId",
                table: "Empleados",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Usuarios_UsuarioId",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Puestos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Puestos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Puestos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Puestos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Puestos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Usuario_UsuarioId",
                table: "Empleados",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
