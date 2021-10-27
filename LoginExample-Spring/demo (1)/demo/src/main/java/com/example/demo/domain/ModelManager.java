package com.example.demo.domain;

import model.Account;
import model.Task;
import network.RemoteModelManager;

import org.springframework.stereotype.Service;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.util.ArrayList;

@Service
public class ModelManager implements Model{
    private RemoteModelManager server;

    public ModelManager() throws MalformedURLException, NotBoundException, RemoteException {
        server = new RemoteModelManager();
    }

    @Override
    public Account findUserByUsername(String username)  {
        try {
            return server.login(username);
        }catch (Exception e){

        }
        return null;
    }

    @Override
    public void addAccount(String username, String password, String role) throws RemoteException {
        try {
            server.addAccount(username, password, role);
        }catch(IllegalArgumentException e){
            System.out.println(e);
        }

    }

    @Override
    public void addTask(String title, String description, int numberOfTeam) throws RemoteException {
            server.addTask(title, description, numberOfTeam);
    }

    @Override
    public ArrayList<Task> getAllTask() throws RemoteException {
        return server.getAllTask();
    }
}
