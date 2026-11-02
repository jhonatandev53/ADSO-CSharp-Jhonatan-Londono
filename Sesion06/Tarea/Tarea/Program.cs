
ProcesadorPagos procesador = new ProcesadorPagos();


IMetodoPago efectivo = new PagoEfectivo();
IMetodoPago tarjeta = new PagoTarjeta("1234567812345678"); 
IMetodoPago billetera = new PagoBilletera("3001234567");


procesador.Cobrar(efectivo, 150_000m);
procesador.Cobrar(tarjeta, 800_000m);
procesador.Cobrar(billetera, 1_500_000m);


procesador.Cobrar(billetera, 2_500_000m);


procesador.Devolver(efectivo, 150_000m);


procesador.Devolver(tarjeta, 800_000m);


procesador.Devolver(billetera, 1_500_000m);