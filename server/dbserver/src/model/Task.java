package model;

import java.io.Serializable;

public class Task implements Serializable {
    private int id;
    private String title;
    private String description;
    private int numberOFTeam;


    public Task(int id, String title, String description, int numberOFTeam) {
        this.id = id;
        this.title = title;
        this.description = description;
        this.numberOFTeam = numberOFTeam;
    }

    public Task(String title, String description, int numberOFTeam) {
        this.title = title;
        this.description = description;
        this.numberOFTeam = numberOFTeam;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public int getNumberOFTeam() {
        return numberOFTeam;
    }

    public void setNumberOFTeam(int numberOFTeam) {
        this.numberOFTeam = numberOFTeam;
    }

    @Override
    public String toString() {
        return "Task{" +
                "id=" + id +
                ", title='" + title + '\'' +
                ", description='" + description + '\'' +
                ", numberOFTeam=" + numberOFTeam +
                '}';
    }
}
