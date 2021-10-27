import network.RemoteModelManager;
import network.RemoteModle;
import persestince.UserDB;

import java.net.MalformedURLException;
import java.rmi.RemoteException;

public class Main {

    public static void main(String[] args) throws MalformedURLException, RemoteException {
      RemoteModle  server = new RemoteModelManager();
        UserDB userDB = new UserDB();
        System.out.println(userDB.Login("linda"));
    }
}
