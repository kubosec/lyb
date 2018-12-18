package pdsu.hrms.view;


import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;

import pdsu.hrms.dao.DeptDao;
import pdsu.hrms.dao.PersonDao;

public class Panel13 extends JPanel implements ActionListener{
	
	//�����������
	//�������
	private JPanel pTop;
	private JPanel pCenter;
	private JPanel pBottom;
	
	
	private JTable table;
	private JScrollPane js;
	
	//�����в��������
	private JLabel lbDeptId;
	private JLabel lbDept1Name;
	private JLabel lbDept2Name;
	
	private  JTextField tfDeptId;
	
	
	private JTextField tfDept2Name;
	private JTextField tfDept1Name;
	
	//����ײ������
	private JButton btnNextId;
	private JButton btnAdd;
	private JButton btnUpdate;
	private JButton btnDelete;
	private JButton btnClear;
	String[][] colValue;
	String[] colTitle = new String[] {"���","����","��������","����","��ַ","����"};
	public Panel13() {
		//����Ϊ�߽粼��
		setLayout(new BorderLayout());
		
		
		
		
		
		initTop();
		initCenter();
		initBottom();
		
	}
	//��ʼ���ϲ����
	public void initTop() {
		pTop = new JPanel();
		//����Ϊ���������
		GridBagLayout gridBag = new GridBagLayout();
		GridBagConstraints cons = null;
		pTop.setLayout(gridBag);
		
		//��ӱ���
		JLabel lbTitle = new JLabel("��Ա��Ϣɾ��");
		lbTitle.setFont(new Font("����",0,16));
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 0;
		gridBag.setConstraints(lbTitle, cons);
		pTop.add(lbTitle);
		
		//�����������
				initContent();  //��ʼ�������Ա��Ϣ����
				js = new JScrollPane(table);
				js.setPreferredSize(new Dimension(450, 310));//350,310
				cons = new GridBagConstraints();
				cons.gridx = 0;
				cons.gridy = 1;
				gridBag.setConstraints(js, cons);
				pTop.add(js);
		
		add(pTop,BorderLayout.NORTH);
	}
	
	public void initContent() {
		//�����ձ��
//		table = new JTable(10,3);
		
		colValue = new String[10][6];
		colValue = PersonDao.getPersonsForTable();
//		colValue[0][0]="1";
//		colValue[0][1]="����";
//		colValue[0][2]="1980-03-19";
//		colValue[0][3]="����";
//		colValue[0][4]="����";
//		colValue[0][5]="����-����";
		
		
		table = new JTable(colValue,colTitle);
		//���ñ���Ĭ�ϴ�С
		table.setPreferredScrollableViewportSize(new Dimension(200,200));
		table.setSelectionMode(DefaultListSelectionModel.SINGLE_SELECTION);
		table.addMouseListener(new MouseListener() {
			
			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub
				int row = table.getSelectedRow();
				
				tfDeptId.setText(colValue[row][0]);
				tfDept1Name.setText(colValue[row][1]);
				tfDept2Name.setText(colValue[row][5]);
			}
			
			@Override
			public void mousePressed(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseExited(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseEntered(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseClicked(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
		});
	}
	public void initCenter() {
	pCenter = new JPanel();
	lbDeptId = new JLabel("���");
	tfDeptId = new JTextField(10);
	
	lbDept1Name = new JLabel("����");
	tfDept1Name = new JTextField(10);
	
	lbDept2Name = new JLabel("����");
	tfDept2Name = new JTextField(10);
	
	
	pCenter.add(lbDeptId);
	pCenter.add(tfDeptId);
	
	pCenter.add(lbDept1Name);
	pCenter.add(tfDept1Name);
	
	
	pCenter.add(lbDept2Name);
	pCenter.add(tfDept2Name);
	add(pCenter,BorderLayout.CENTER);
	}
	
	
	public void initBottom() {
		pBottom =  new JPanel();
		btnDelete = new JButton("ɾ��");
		btnDelete.addActionListener(this);
		
		pBottom.add(btnDelete);
		add(pBottom,BorderLayout.SOUTH);
	}
	private void updateTable() {
		colValue = PersonDao.getPersonsForTable();
		DefaultTableModel tableModel = new DefaultTableModel(colValue,colTitle);
		table.setModel(tableModel);
	}
	
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		if(e.getSource()==btnDelete) {
			//�ӽ����ȡ����
			String deptId = tfDeptId.getText();
//			String dept1Name = tfDept1Name.getText();
//			String dept2Name = tfDept2Name.getText();
//			System.out.println(deptId);
			//������֤
			if(deptId==null||deptId.equals("")) {
				JOptionPane.showMessageDialog(null, "��������Ա���!");
				return ;
			}
			//ɾ�����ݿ��ж�Ӧ�Ĳ�����Ϣ
			PersonDao.delete(Long.parseLong(deptId));
			JOptionPane.showMessageDialog(null, "ɾ���ɹ���");
			
			//���±������
			updateTable();
		}

	}

}
