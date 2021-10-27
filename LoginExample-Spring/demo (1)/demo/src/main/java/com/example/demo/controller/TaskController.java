package com.example.demo.controller;


import com.example.demo.domain.Model;
import model.Task;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

import java.rmi.RemoteException;
import java.util.ArrayList;

@RestController
@RequestMapping("api/task")
public class TaskController {
    private Model model;

    @Autowired
    public TaskController(Model model) {
        this.model = model;
    }

    @PostMapping()
    @PreAuthorize("hasAnyRole('ROLE_Admin')")
    public void addTasks(@RequestBody Task task) throws RemoteException {
        model.addTask(task.getTitle(), task.getDescription(), task.getNumberOFTeam());
    }

    @GetMapping()
    @PreAuthorize("hasAnyRole('ROLE_Admin')")
    public ArrayList<Task> getAllTask() throws RemoteException {
       return model.getAllTask();
    }
}
