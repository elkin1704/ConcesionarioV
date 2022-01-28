using ConcesionarioV.Entidades;
using System;
using System.Collections.Generic;

namespace CargaDatos
{
    public class CargaInicial
    {
        
            public Dictionary<string, object> Carga() 
            { 
            //Inventario 
            Inventario inv = new Inventario()
            {
                Marca = "Chevrolet",
                Unidades = 5,
                Modelo = "Aveo",
                Color = "Negro-Azul-Gris",
                Estado = "Nuevo",
                Precio_por_unidad = 18.000M

            };
            Inventario inv2 = new Inventario()
            {
                Marca = "Chevrolet",
                Unidades = 3,
                Modelo = "Spark",
                Color = "Negro-Azul-Rojo",
                Estado = "Usado",
                Precio_por_unidad = 12.000M

            };
            Inventario inv3 = new Inventario()
            {
                Marca = "Chevrolet",
                Unidades = 4,
                Modelo = "Orlando",
                Color = "Gris-Blanco",
                Estado = "Nuevo",
                Precio_por_unidad = 26.000M

            };
            Inventario inv4 = new Inventario()
            {
                Marca = "Chevrolet",
                Unidades = 2,
                Modelo = "Camaro",
                Color = "Negro-Amarillo",
                Estado = "Nuevo",
                Precio_por_unidad = 43.000M,

            };
            Inventario inv5 = new Inventario()
            {
                Marca = "Kia",
                Unidades = 3,
                Modelo = "Picanto",
                Color = "Negro-Rojo-Blanco",
                Estado = "Usado",
                Precio_por_unidad = 13.000M,

            };
            Inventario inv6 = new Inventario()
            {
                Marca = "Kia",
                Unidades = 6,
                Modelo = "Sportage",
                Color = "Blanco-Negro",
                Estado = "Nuevo",
                Precio_por_unidad = 28.000M,

            };
            Inventario inv7 = new Inventario()
            {
                Marca = "Kia",
                Unidades = 4,
                Modelo = "Rio",
                Color = "Negro-Azul",
                Estado = "Nuevo",
                Precio_por_unidad = 19.000M,

            };
            Inventario inv8 = new Inventario()
            {
                Marca = "Nissan",
                Unidades = 2,
                Modelo = "Note",
                Color = "Gris-Blanco-Negro",
                Estado = "Nuevo",
                Precio_por_unidad = 17.000M,

            };
            Inventario inv9 = new Inventario()
            {
                Marca = "Nissan",
                Unidades = 1,
                Modelo = "Leaf",
                Color = "Azul-Blanco",
                Estado = "Nuevo",
                Precio_por_unidad = 22.000M,

            };
            Inventario inv10 = new Inventario()
            {
                Marca = "Nissan",
                Unidades = 5,
                Modelo = "Navara",
                Color = "Negro-Azul-Gris",
                Estado = "Nuevo",
                Precio_por_unidad = 38.000M,

            };
            Inventario inv11 = new Inventario()
            {
                Marca = "Nissan",
                Unidades = 3,
                Modelo = "Micra",
                Color = "Negro-Rojo-Blanco",
                Estado = "Usado",
                Precio_por_unidad = 25.000M,

            };
            Inventario inv12 = new Inventario()
            {
                Marca = "Nissan",
                Unidades = 4,
                Modelo = "Juke",
                Color = "Negro-Azul-Rojo",
                Estado = "Nuevo",
                Precio_por_unidad = 34.000M,

            };
            Inventario inv13 = new Inventario()
            {
                Marca = "Toyota",
                Unidades = 2,
                Modelo = "Rav4",
                Color = "Blanco-Negro",
                Estado = "Nuevo",
                Precio_por_unidad = 39.000M,

            };
            List<Inventario> listaInv = new List<Inventario>()
            {
                inv,inv2,inv3,inv4,inv5,inv6,inv7,
                inv8,inv9,inv10,inv11,inv12,  inv13
            };

            //Distribuidora
            Distribuidora dis = new Distribuidora()
            {
                Distribuidor = "Chevrolet",
                Modelo = "Spark",
                Unidades = 2,
                Motivo = "Minimo-Igualado",
                Precio_Total = 28.800M

            };
            Distribuidora dis2 = new Distribuidora()
            {
                Distribuidor = "Chevrolet",
                Modelo = "Camaro",
                Unidades = 4,
                Motivo = "Minimo-Vencido",
                Precio_Total = 137.600M

            };
            Distribuidora dis3 = new Distribuidora()
            {
                Distribuidor = "Kia",
                Modelo = "Picanto",
                Unidades = 2,
                Motivo = "Minimo-Igualado",
                Precio_Total = 41.600M

            };
            Distribuidora dis4 = new Distribuidora()
            {
                Distribuidor = "Nissan",
                Modelo = "Note",
                Unidades = 4,
                Motivo = "Minimo-Vencido",
                Precio_Total = 54.400M

            };
            Distribuidora dis5 = new Distribuidora()
            {
                Distribuidor = "Nissan",
                Modelo = "Leaf",
                Unidades = 4,
                Motivo = "Minimo-Vencido",
                Precio_Total = 70.400M

            };
            Distribuidora dis6 = new Distribuidora()
            {
                Distribuidor = "Nissan",
                Modelo = "Micra",
                Unidades = 2,
                Motivo = "Minimo-Igualado",
                Precio_Total = 40.000M

            };
            Distribuidora dis7 = new Distribuidora()
            {
                Distribuidor = "Toyota",
                Modelo = "Rav4",
                Unidades = 4,
                Motivo = "Minimo-Vencido",
                Precio_Total = 124.800M

            };
            List<Distribuidora> listaDis = new List<Distribuidora>()
            {
                dis,dis2,dis3,dis4,dis5,dis6,dis7
            };
            //DatosCliente
            DatosCliente dat = new DatosCliente()
            {
                Nombres_Completos = "Elkin David Romero Torres",
                Correo = "elkin17@gmail.com",
                Telefono = 0997978612,
                Direccion = "Ajavi y Serapio Japerabi"
            };
            DatosCliente dat2 = new DatosCliente()
            {
                Nombres_Completos = "Marco Eduardo Taco Betancourt",
                Correo = "eduardo@gmail.com",
                Telefono = 0997978451,
                Direccion = "Conocoto"
            };
            DatosCliente dat3 = new DatosCliente()
            {
                Nombres_Completos = "Adrian Sebastian Siguencia Remache",
                Correo = "adrian@gmail.com",
                Telefono = 0997978789,
                Direccion = "La Planada"
            };
            DatosCliente dat4 = new DatosCliente()
            {
                Nombres_Completos = "Alex Kevin Pintado Guaman",
                Correo = "alex@gmail.com",
                Telefono = 0997978123,
                Direccion = "San Martin"
            };
            DatosCliente dat5 = new DatosCliente()
            {
                Nombres_Completos = "Luis Alfredo Lopez Condo",
                Correo = "luis@gmail.com",
                Telefono = 0997972457,
                Direccion = "Mitad del Mundo"
            };
            List<DatosCliente> listaDat = new List<DatosCliente>()
            {
                dat,dat2,dat3,dat4,dat5
            };

            //Rol de Pagos
            RolPago rolp = new RolPago()
            {
                DatosClientes= dat,
                Cliente = "Elkin David Romero Torres",
                Cargo = "Empleado Privado",
                Sueldo = 3.500M,
                Horas_extra = 0,
                Comision = 100M,
                AporteIEES = 336.60M,
                Anticipos = 50M,
                Total = 3.213M
            };
            RolPago rolp2 = new RolPago()
            {
                DatosClientes = dat2,
                Cliente = "Marco Eduardo Taco Betancourt",
                Cargo = "Empleado Privado",
                Sueldo = 900M,
                Horas_extra = 0,
                Comision = 50M,
                AporteIEES = 88.83M,
                Anticipos = 50M,
                Total = 811.18M
            };
            RolPago rolp3 = new RolPago()
            {
                DatosClientes = dat3,
                Cliente = "Adrian Sebastian Siguencia Remache",
                Cargo = "Empleado Publico",
                Sueldo = 3.500M,
                Horas_extra = 0,
                Comision = 100M,
                AporteIEES = 336.60M,
                Anticipos = 50M,
                Total = 3.21340M
            };
            RolPago rolp4 = new RolPago()
            {
                DatosClientes = dat4,
                Cliente = "Alex Kevin Pintado Guaman",
                Cargo = "Empleado Privado",
                Sueldo = 1.600M,
                Horas_extra = 0,
                Comision = 75M,
                AporteIEES = 156.61M,
                Anticipos = 50M,
                Total = 1.456839M
            };
            RolPago rolp5 = new RolPago()
            {
                DatosClientes = dat5,
                Cliente = "Luis Alfredo Lopez Condo",
                Cargo = "Empleado Publico",
                Sueldo = 1.000M,
                Horas_extra = 0,
                Comision = 150M,
                AporteIEES = 107.53M,
                Anticipos = 25M,
                Total = 1.01748M
            };
            List<RolPago> listaRolp = new List<RolPago>()
            {
                rolp,rolp2,rolp3,rolp4,rolp5
            };

            //Informe
            InformeGasto infg = new InformeGasto()
            {
                DatosClientes = dat,
                Cliente = "Elkin David Romero Torres",
                Agua = 5.0M,
                Luz = 35M,
                Telefono = 50,
                Otros_servicios = 150M,
                Total = 240M

            };
            InformeGasto infg2 = new InformeGasto()
            {
                DatosClientes = dat2,
                Cliente = "Eduardo Marco Taco Bentancourt",
                Agua = 7.0M,
                Luz = 40M,
                Telefono = 35,
                Otros_servicios = 175M,
                Total = 257M

            };
            InformeGasto infg3 = new InformeGasto()
            {
                DatosClientes = dat3,
                Cliente = "Adrian Sebastian Siguencia Remache",
                Agua = 4.0M,
                Luz = 20M,
                Telefono = 40,
                Otros_servicios = 150M,
                Total = 214M

            };
            InformeGasto infg4 = new InformeGasto()
            {
                DatosClientes = dat4,
                Cliente = "Alex Kevin Pintado Guaman",
                Agua = 6.0M,
                Luz = 25M,
                Telefono = 18,
                Otros_servicios = 125M,
                Total = 174M

            };
            InformeGasto infg5 = new InformeGasto()
            {
                DatosClientes = dat5,
                Cliente = "Luis Alfredo Lopez Condo",
                Agua = 5.0M,
                Luz = 15M,
                Telefono = 23,
                Otros_servicios = 175M,
                Total = 218M

            };
            List<InformeGasto> listainfg = new List<InformeGasto>()
            {
                infg,infg2,infg3,infg4,infg5
            };
            TablaAmortizacion tabAmo = new TablaAmortizacion()
            {
                Inventarios = inv,
                Cliente = "Elkin David Romero Torres",
                TNA30_360 = "20%",
                Años = 10,
                ValorPrestamo = 38.000M,
                Frecuencia = "Mensual",
                InteresEquivalente = "0.833%",
                Numeropagos = 1,
                NumeroCuotas = 120

            };
            TablaAmortizacion tabAmo2 = new TablaAmortizacion()
            {
                Inventarios = inv2,
                Cliente = "Marco Eduardo Taco Bentancourt",
                TNA30_360 = "10%",
                Años = 5,
                ValorPrestamo = 12.000M,
                Frecuencia = "Mensual",
                InteresEquivalente = "0.833%",
                Numeropagos = 1,
                NumeroCuotas = 60

            };
            TablaAmortizacion tabAmo3 = new TablaAmortizacion()
            {
                Inventarios = inv3,
                Cliente = "Adrian Sebastian Siguencia Remache",
                TNA30_360 = "10%",
                Años = 5,
                ValorPrestamo = 13.000M,
                Frecuencia = "Mensual",
                InteresEquivalente = "0.833%",
                Numeropagos = 1,
                NumeroCuotas = 60

            };
            TablaAmortizacion tabAmo4 = new TablaAmortizacion()
            {
                Inventarios = inv4,
                Cliente = "Alex kevin Pintado Guaman",
                TNA30_360 = "10%",
                Años = 5,
                ValorPrestamo = 18.000M,
                Frecuencia = "Mensual",
                InteresEquivalente = "0.833%",
                Numeropagos = 1,
                NumeroCuotas = 60

            };
            TablaAmortizacion tabAmo5 = new TablaAmortizacion()
            {
                Inventarios = inv5,
                Cliente = "Luis Alfredo Lopez Condo",
                TNA30_360 = "10%",
                Años = 5,
                ValorPrestamo = 18.000M,
                Frecuencia = "Mensual",
                InteresEquivalente = "0.833%",
                Numeropagos = 1,
                NumeroCuotas = 60

            };
            List<TablaAmortizacion> listataba = new List<TablaAmortizacion>()
            {
                tabAmo,tabAmo2,tabAmo3,tabAmo4,tabAmo5
            };

            IngresoNeto ingN = new IngresoNeto()
            {
                RolPagos = rolp,
                InformeGastos= infg,
                Cliente = "Elkin David Romero Torres",
                Rol_Pagos_Netos = 3213.40M,
                Servicios_Basicos_Netos = 240.00M,
                Ingresos_Totales = 2973.40M,
                Valor_Aprobacion = 1189.36M

            };
            IngresoNeto ingN2 = new IngresoNeto()
            {
                RolPagos= rolp2,
                InformeGastos = infg2,
                Cliente = "Marco Eduardo Taco Betancourt",
                Rol_Pagos_Netos = 811.18M,
                Servicios_Basicos_Netos = 257.00M,
                Ingresos_Totales = 554.18M,
                Valor_Aprobacion = 221.67M

            };
            IngresoNeto ingN3 = new IngresoNeto()
            {
                RolPagos = rolp3,
                InformeGastos = infg3,
                Cliente = "Adrian Sebastian Siguencia Remache",
                Rol_Pagos_Netos = 926.83M,
                Servicios_Basicos_Netos = 214.00M,
                Ingresos_Totales = 712.83M,
                Valor_Aprobacion = 285.13M

            };
            IngresoNeto ingN4 = new IngresoNeto()
            {
                RolPagos = rolp4,
                InformeGastos = infg4,
                Cliente = "Alex Kevin Pintado Guaman",
                Rol_Pagos_Netos = 1468.39M,
                Servicios_Basicos_Netos = 174.00M,
                Ingresos_Totales = 1294.39M,
                Valor_Aprobacion = 517.76M

            };
            IngresoNeto ingN5 = new IngresoNeto()
            {
                RolPagos = rolp5,
                InformeGastos = infg5,
                Cliente = "Luis Alfredo Lopez Condo",
                Rol_Pagos_Netos = 1017.48M,
                Servicios_Basicos_Netos = 218.00M,
                Ingresos_Totales = 799.48M,
                Valor_Aprobacion = 319.79M

            };
            List<IngresoNeto> listaIngN = new List<IngresoNeto>()
            {
                ingN,ingN2,ingN3,ingN4,ingN5
            };

            ResumenAmortizacion resA = new ResumenAmortizacion()
            {
                IngresoNetos= ingN,
                TablaAmortizacions= tabAmo,
                Cliente = "Elkin David Romero Torres",
                ValorPrestamo= 38.000M,
                CuotaMensual=734.37M,
                SumaInteres=50124.59M,
                SumaCuotas=88124.59M,
                Prestamo="Aprobado"
               

            };
            ResumenAmortizacion resA2 = new ResumenAmortizacion()
            {
                IngresoNetos = ingN2,
                TablaAmortizacions = tabAmo2,
                Cliente = "Marco Eduardo Taco Bentancourt",
                ValorPrestamo = 12.000M,
                CuotaMensual = 254.96M,
                SumaInteres = 7075.60M,
                SumaCuotas = 19075.60M,
                Prestamo = "Rechazado"

            };
            ResumenAmortizacion resA3 = new ResumenAmortizacion()
            {
                IngresoNetos = ingN3,
                TablaAmortizacions = tabAmo3,
                Cliente = "Adrian Sebastian Siguencia Remache",
                ValorPrestamo = 13.000M,
                CuotaMensual = 276.21M,
                SumaInteres = 3572.69M,
                SumaCuotas = 16572.69M,
                Prestamo = "Aprobado"

            };
            ResumenAmortizacion resA4 = new ResumenAmortizacion()
            {
                IngresoNetos = ingN4,
                TablaAmortizacions = tabAmo4,
                Cliente = "Alex Kevin Pintado Guaman",
                ValorPrestamo = 18.000M,
                CuotaMensual = 382.45M,
                SumaInteres = 4946.81M,
                SumaCuotas = 22946.81M,
                Prestamo = "Aprobado"

            };
            ResumenAmortizacion resA5 = new ResumenAmortizacion()
            {
                IngresoNetos = ingN5,
                TablaAmortizacions = tabAmo5,
                Cliente = "Luis Alfredo Lopez ",
                ValorPrestamo = 43.000M,
                CuotaMensual = 913.62M,
                SumaInteres = 11817.38M,
                SumaCuotas = 54817.38M,
                Prestamo = "Rechazado"

            };
            List<ResumenAmortizacion> listaresA = new List<ResumenAmortizacion>()
            {
               resA,resA2,resA3,resA4,resA5
            };
            FacturaDistribuidora factdis = new FacturaDistribuidora()
            {
                Inventarios = inv,
                Distribuidoras= dis,
                Fecha="27/01/2022"

            };
            FacturaDistribuidora factdis2 = new FacturaDistribuidora()
            {
                Inventarios = inv2,
                Distribuidoras = dis2,
                Fecha = "27/01/2022"


            };
            FacturaDistribuidora factdis3 = new FacturaDistribuidora()
            {
                Inventarios = inv3,
                Distribuidoras = dis3,
                Fecha = "27/01/2022"


            };
            FacturaDistribuidora factdis4 = new FacturaDistribuidora()
            {
                Inventarios = inv4,
                Distribuidoras = dis4,
                Fecha = "27/01/2022"


            };
            FacturaDistribuidora factdis5 = new FacturaDistribuidora()
            {
                Inventarios = inv5,
                Distribuidoras = dis5,
                Fecha = "27/01/2022"


            };
            FacturaDistribuidora factdis6 = new FacturaDistribuidora()
            {
                Inventarios = inv6,
                Distribuidoras = dis6,
                Fecha = "27/01/2022"


            };
            FacturaDistribuidora factdis7 = new FacturaDistribuidora()
            {
                Inventarios = inv7,
                Distribuidoras = dis7,
                Fecha = "27/01/2022"


            };
            List<FacturaDistribuidora> listFa = new List<FacturaDistribuidora>()
            {
               factdis,factdis2,factdis3,factdis4,factdis5,factdis6,factdis7
            };


            //Diccionario contiene todas las listas
            Dictionary<string, object> diccionarioListDatos = new Dictionary<string, object>()
            {
                {"Inventario", listaInv},
                {"Distribuidora", listaDis},
                {"DatosCliente", listaDat},
                {"RolPagos", listaRolp},
                {"InformeGastos", listainfg},
                {"TablaAmortizacion", listataba},
                {"IngresosNetos", listaIngN},
                {"ResumenAmortizacion", listaresA},
                {"FacturaDistribuidora", listFa}

            };

            return diccionarioListDatos;
        }
    }
}
