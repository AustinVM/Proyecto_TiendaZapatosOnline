namespace CapaEntidades
{
    public class Ce_Municipio
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int id_Departamento { get; set; }
        public bool estado { get; set; }

        public Ce_Municipio()
        {
            id = 0;
            nombre = "";
            id_Departamento = 0;
            estado = true;
        }
    }
}
