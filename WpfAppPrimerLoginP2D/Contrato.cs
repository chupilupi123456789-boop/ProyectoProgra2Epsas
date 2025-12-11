namespace WpfAppPrimerLoginP2D
{
    public class Contrato
    {
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string TipoContrato { get; set; }
        public string FechaIngreso { get; set; }

        public Contrato() { }

        public Contrato(string cargo, string departamento, string tipoContrato, string fechaIngreso)
        {
            Cargo = cargo;
            Departamento = departamento;
            TipoContrato = tipoContrato;
            FechaIngreso = fechaIngreso;
        }
    }
}
