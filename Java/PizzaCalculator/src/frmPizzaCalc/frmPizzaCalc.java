/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package frmPizzaCalc;

import java.text.DecimalFormat;

/**
 *
 * @author el51909
 */
public class frmPizzaCalc extends javax.swing.JFrame {

    /**
     * Creates new form frmPizzaCalc
     */
    public frmPizzaCalc() {
        initComponents();
        this.rBtnSmall.setSelected(true);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btnGroupCrust = new javax.swing.ButtonGroup();
        lblCrust = new javax.swing.JLabel();
        rBtnSmall = new javax.swing.JRadioButton();
        rBtnMedium = new javax.swing.JRadioButton();
        rBtnLarge = new javax.swing.JRadioButton();
        lblToppings = new javax.swing.JLabel();
        ckbPepperoni = new javax.swing.JCheckBox();
        ckbCanadian = new javax.swing.JCheckBox();
        ckbSausage = new javax.swing.JCheckBox();
        ckbBlackOlives = new javax.swing.JCheckBox();
        ckbMushroom = new javax.swing.JCheckBox();
        ckbOnions = new javax.swing.JCheckBox();
        lblPrice = new javax.swing.JLabel();
        lblPriceoutput = new javax.swing.JLabel();
        btnCalc = new javax.swing.JButton();
        btnClear = new javax.swing.JButton();
        btnExit = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Pizza Calculator");
        setLocation(new java.awt.Point(750, 350));
        setName("frmPizzaCalc"); // NOI18N

        lblCrust.setFont(new java.awt.Font("Segoe UI", 1, 24)); // NOI18N
        lblCrust.setText("Crust:");

        btnGroupCrust.add(rBtnSmall);
        rBtnSmall.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        rBtnSmall.setText("Small");

        btnGroupCrust.add(rBtnMedium);
        rBtnMedium.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        rBtnMedium.setText("Medium");

        btnGroupCrust.add(rBtnLarge);
        rBtnLarge.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        rBtnLarge.setText("Large");

        lblToppings.setFont(new java.awt.Font("Segoe UI", 1, 24)); // NOI18N
        lblToppings.setText("Toppings:");

        ckbPepperoni.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        ckbPepperoni.setText("Pepperoni");

        ckbCanadian.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        ckbCanadian.setText("Canadian Bacon");

        ckbSausage.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        ckbSausage.setText("Sausage");

        ckbBlackOlives.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        ckbBlackOlives.setText("Black Olives");

        ckbMushroom.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        ckbMushroom.setText("Mushrooms");

        ckbOnions.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        ckbOnions.setText("Onions");

        lblPrice.setFont(new java.awt.Font("Segoe UI", 1, 18)); // NOI18N
        lblPrice.setText("Price:");

        lblPriceoutput.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblPriceoutput.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));
        lblPriceoutput.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);

        btnCalc.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        btnCalc.setText("Calculate Price");
        btnCalc.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCalcActionPerformed(evt);
            }
        });

        btnClear.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        btnClear.setText("Clear");
        btnClear.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnClearActionPerformed(evt);
            }
        });

        btnExit.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        btnExit.setText("Exit");
        btnExit.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnExitActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(lblPrice)
                                .addGap(18, 18, 18)
                                .addComponent(lblPriceoutput, javax.swing.GroupLayout.PREFERRED_SIZE, 117, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addComponent(lblCrust)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(rBtnSmall)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(rBtnMedium)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(rBtnLarge))
                            .addComponent(lblToppings)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(ckbPepperoni)
                                .addGap(50, 50, 50)
                                .addComponent(ckbBlackOlives))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(ckbCanadian)
                                    .addComponent(ckbSausage))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(ckbOnions)
                                    .addComponent(ckbMushroom))))
                        .addGap(0, 103, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(btnCalc, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(btnClear, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(btnExit, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblCrust)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(rBtnSmall)
                    .addComponent(rBtnMedium)
                    .addComponent(rBtnLarge))
                .addGap(18, 18, 18)
                .addComponent(lblToppings)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(ckbPepperoni)
                    .addComponent(ckbBlackOlives))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(ckbCanadian)
                    .addComponent(ckbMushroom))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(ckbSausage)
                    .addComponent(ckbOnions))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblPriceoutput, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 29, Short.MAX_VALUE)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(lblPrice)
                        .addComponent(btnCalc)))
                .addGap(18, 18, 18)
                .addComponent(btnClear)
                .addGap(18, 18, 18)
                .addComponent(btnExit)
                .addContainerGap())
        );

        rBtnSmall.getAccessibleContext().setAccessibleDescription("");
        lblPriceoutput.getAccessibleContext().setAccessibleName("lblPriceOutput");

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnCalcActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCalcActionPerformed
        // TODO add your handling code here:
        resetPrice();
        DecimalFormat df = new DecimalFormat("0.00");
        
        double dblCrustPrice = getCrustPrice(rBtnSmall.isSelected(), rBtnMedium.isSelected(), rBtnLarge.isSelected());
        
        this.lblPriceoutput.setText("$" + df.format(dblCrustPrice + getToppings()));
        
    }//GEN-LAST:event_btnCalcActionPerformed

    private void btnClearActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnClearActionPerformed
        // TODO add your handling code here:
        this.rBtnSmall.setSelected(true);
        
        //clear toppings
        this.ckbBlackOlives.setSelected(false);
        this.ckbCanadian.setSelected(false);
        this.ckbMushroom.setSelected(false);
        this.ckbOnions.setSelected(false);
        this.ckbPepperoni.setSelected(false);
        this.ckbSausage.setSelected(false);
        
        resetPrice();
    }//GEN-LAST:event_btnClearActionPerformed

    private void btnExitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnExitActionPerformed
        // TODO add your handling code here:
        System.exit(0);
    }//GEN-LAST:event_btnExitActionPerformed
    private void resetPrice(){
        //load with a "0"
        this.lblPriceoutput.setText("$0");
    }
    
    private double getCrustPrice(boolean small, boolean medium, boolean large){
        double dblPrice = 0;
        
        if(small){
            dblPrice += 6.99;
        }else if(medium){
            dblPrice += 10.99;
        }else if(large){
            dblPrice += 16.99;
        }
        return dblPrice;
    }
    private double getToppings(){
        double dblPrice = 0;
        if(this.ckbPepperoni.isSelected()){
            dblPrice += 1.49;
        }
        if(this.ckbCanadian.isSelected()){
            dblPrice += 1.49;
        }
        if(this.ckbSausage.isSelected()){
            dblPrice += 1.49;
        }
        if(this.ckbBlackOlives.isSelected()){
            dblPrice += .99;
        }
        if(this.ckbMushroom.isSelected()){
            dblPrice += .99;
        }
        if(this.ckbOnions.isSelected()){
            dblPrice += .99;
        }
        return dblPrice;
    }
    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(frmPizzaCalc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frmPizzaCalc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frmPizzaCalc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frmPizzaCalc.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new frmPizzaCalc().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnCalc;
    private javax.swing.JButton btnClear;
    private javax.swing.JButton btnExit;
    private javax.swing.ButtonGroup btnGroupCrust;
    private javax.swing.JCheckBox ckbBlackOlives;
    private javax.swing.JCheckBox ckbCanadian;
    private javax.swing.JCheckBox ckbMushroom;
    private javax.swing.JCheckBox ckbOnions;
    private javax.swing.JCheckBox ckbPepperoni;
    private javax.swing.JCheckBox ckbSausage;
    private javax.swing.JLabel lblCrust;
    private javax.swing.JLabel lblPrice;
    private javax.swing.JLabel lblPriceoutput;
    private javax.swing.JLabel lblToppings;
    private javax.swing.JRadioButton rBtnLarge;
    private javax.swing.JRadioButton rBtnMedium;
    private javax.swing.JRadioButton rBtnSmall;
    // End of variables declaration//GEN-END:variables
}
