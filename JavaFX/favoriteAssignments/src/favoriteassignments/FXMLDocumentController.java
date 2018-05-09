/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package favoriteassignments;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;

/**
 *
 * @author el51909
 */
public class FXMLDocumentController implements Initializable {
    
    @FXML private Label lblName;
    @FXML private Label lblFood;
    @FXML private Label lblMovie;
    @FXML private Label lblColor;
    @FXML private Label lblBook;
    @FXML private Label lblTV;
    @FXML private Label lblPlace;
    @FXML private Label lblPeeve;
    
    
    @FXML
    private void knowMeBetter(ActionEvent e) {
        lblName.setText("Erik Lee");
        lblFood.setText("Pizza");
        lblMovie.setText("Lord of the Rings");
        lblColor.setText("Green");
        lblBook.setText("To Kill a Mockingbird");
        lblTV.setText("Stranger Things");
        lblPlace.setText("Colorado");
        lblPeeve.setText("Looking over my shoulder");
    }
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    
    
}
