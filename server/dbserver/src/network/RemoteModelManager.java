package network;



import model.Account;
import model.Task;
import persestince.TaskDB;
import persestince.UserDB;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;

public class RemoteModelManager implements RemoteModle{
    private UserDB userDB;
    private TaskDB taskDB;

    public RemoteModelManager() throws RemoteException, MalformedURLException {
         startRegistry();
         startServer();
         userDB = new UserDB();
         taskDB = new TaskDB();
    }
    private void startRegistry() throws RemoteException {
        try {
            Registry reg = LocateRegistry.createRegistry(1099);
            System.out.println("Registry started...");
        } catch (java.rmi.server.ExportException e) {
            System.out.println("Registry already started? " + e.getMessage());
        }
    }

    private void startServer() throws RemoteException, MalformedURLException {
        UnicastRemoteObject.exportObject(this, 0);
        Naming.rebind("Server", this);
        System.out.println("Server started...");
    }

    @Override
    public Account login(String username) throws RemoteException{
        Account account =  userDB.Login(username);
        if(account == null){
            throw new IllegalArgumentException("user not exist");
        }

        return account;
    }

    @Override
    public void addAccount(String username, String password, String role) throws RemoteException{
        userDB.AddAcount(username, password, role);
    }

    @Override
    public void addTask(String title, String description, int numberOfTeam)throws RemoteException {
        taskDB.addTask(title,description,numberOfTeam);
    }

    @Override
    public ArrayList<Task> getAllTask()throws RemoteException {
        ArrayList<Task> tasks = new ArrayList<>();
        try {
            tasks = taskDB.getAllTasks();
        }catch (Exception e){
            System.out.println(e.getMessage());
        }
        return tasks;
    }

}
