package network;




import model.Account;
import model.Task;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;

public interface RemoteModle extends Remote {
    Account login(String username) throws RemoteException;
    void addAccount(String username, String password, String role) throws RemoteException;
    void addTask(String title, String description, int numberOfTeam) throws RemoteException;
    ArrayList<Task> getAllTask() throws RemoteException;

}
