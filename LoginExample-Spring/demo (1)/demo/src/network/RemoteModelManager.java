package network;

import model.Account;
import model.Task;
import org.springframework.stereotype.Service;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.util.ArrayList;

public class RemoteModelManager implements RemoteModle{

    private RemoteModle server;

    public RemoteModelManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.server = (RemoteModle) Naming.lookup("rmi://localhost:1099/Server");

    }

    @Override
    public Account login(String username) throws RemoteException {
        return server.login(username);
    }

    @Override
    public void addAccount(String username, String password, String role) throws RemoteException{
        server.addAccount(username, password, role);
    }

    @Override
    public void addTask(String title, String description, int numberOfTeam) throws RemoteException{
            server.addTask(title, description, numberOfTeam);
    }

    @Override
    public ArrayList<Task> getAllTask() throws RemoteException {
        return server.getAllTask();
    }
}
