package persestince;




import model.Account;

import java.sql.*;


public class UserDB {

    public Account Login(String username){
        try(Connection connection= ConnectionDB.getInstance().getConnection()){
            PreparedStatement statement = connection.prepareStatement("SELECT * from account WHERE username =?");
            statement.setString(1,username);

            ResultSet resultSet = statement.executeQuery();
            if (resultSet.next()){
                return new Account(resultSet.getString("username"), resultSet.getString("password"), resultSet.getString("role"));
            }
        }catch (SQLException e){
            throw new IllegalArgumentException(e.getMessage());
        }
        return null;
    }

    public Account AddAcount(String username, String password, String role){
        try(Connection connection= ConnectionDB.getInstance().getConnection()){
            PreparedStatement statement = connection.prepareStatement("INSERT INTO account(username, password, role) VALUES(?,?,?)");
            statement.setString(1,username);
            statement.setString(2,password);
            statement.setString(3,role);

            ResultSet resultSet = statement.executeQuery();
            if (resultSet.next()){
                return new Account(resultSet.getString("username"), resultSet.getString("password"), resultSet.getString("role"));
            }
        }catch (SQLException e){
            throw new IllegalArgumentException(e.getMessage());
        }
        return null;
    }
}
