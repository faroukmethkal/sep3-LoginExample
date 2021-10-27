package persestince;


import java.sql.*;

public class ConnectionDB {
    private static ConnectionDB instance;
    private final static String URL = "jdbc:postgresql://localhost:5432/postgres?currentSchema=";
    private final static String SCHEMA_NAME="sep3login";
    private final static String USERNAME="postgres";
    private final static String PASSWORD="farouk_12";


    private ConnectionDB()throws SQLException{
        DriverManager.registerDriver(new org.postgresql.Driver());
    }

    public static synchronized ConnectionDB getInstance() throws SQLException{
        if (instance == null){
            instance = new ConnectionDB();
        }
        return instance;
    }

    public Connection getConnection() throws SQLException {

        return DriverManager.getConnection(URL + SCHEMA_NAME, USERNAME, PASSWORD);

    }

}
