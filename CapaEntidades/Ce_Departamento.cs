namespace CapaEntidades
{
    public class Ce_Departamento
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool estado { get; set; }

        public Ce_Departamento()
        {
            id = 0;
            nombre = "";
            estado = true;
        }
    }
}
