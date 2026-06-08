using Microsoft.Data.SqlClient;

public static class ConexionEjemplo
{
    private static string cadenaConexion = "Server=PONER_IP_AWS,1433;Database=InmobiliariaClarita;User Id=unah;Password=PONER_CONTRASEÑA_AQUÍ;TrustServerCertificate=True;";

    public static SqlConnection ObtenerConexion()
    {
        return new SqlConnection(cadenaConexion);
    }
}