package persestince;

import model.Account;
import model.Task;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class TaskDB {

    public Task getTask(int id){
        try(Connection connection= ConnectionDB.getInstance().getConnection()){
            PreparedStatement statement = connection.prepareStatement("SELECT * from task WHERE id=? ");
            statement.setString(1,Integer.toString(id));


            ResultSet resultSet = statement.executeQuery();
            if (resultSet.next()){
                return new Task(Integer.parseInt(resultSet.getString("id")),
                        resultSet.getString("title"),
                        resultSet.getString("description"),
                       Integer.parseInt(resultSet.getString("numberOfTeam")));
            }
        }catch (SQLException e){
            throw new IllegalArgumentException(e.getMessage());
        }
        return null;
    }

    public void addTask(String title, String desc, int numberOfTeam){
        try(Connection connection= ConnectionDB.getInstance().getConnection()){
            PreparedStatement statement = connection.prepareStatement("INSERT INTO task (title,description,numberOfTeam ) VALUES (?,?,?)");
            statement.setString(1,title);
            statement.setString(2,desc);
            statement.setString(3,Integer.toString(numberOfTeam));

            ResultSet resultSet = statement.executeQuery();
            if (resultSet.next()){

            }else {
                throw new IllegalArgumentException("Task not added");
            }
        }catch (SQLException e){
            throw new IllegalArgumentException(e.getMessage());
        }
    }

    public ArrayList<Task> getAllTasks(){
        try(Connection connection= ConnectionDB.getInstance().getConnection()){
            PreparedStatement statement = connection.prepareStatement("SELECT * from task ");

            ResultSet resultSet = statement.executeQuery();
            ArrayList<Task> tasks = new ArrayList<>();
            while (resultSet.next()){
                      int id =  Integer.parseInt(resultSet.getString("id"));
                      String title = resultSet.getString("title");
                      String description = resultSet.getString("description");
                       int numberOfTeam =  Integer.parseInt(resultSet.getString("numberOfTeam"));
                      Task task = new Task(id,title,description,numberOfTeam);
                      tasks.add(task);
            }
            return tasks;
        }catch (SQLException e){
            throw new IllegalArgumentException(e.getMessage());
        }

    }
}
