package pdsu.hrms.view;

import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextField;

import pdsu.hrms.dao.DeptDao;
import pdsu.hrms.dao.PersonDao;
import pdsu.hrms.model.Person;

public class Panel12 extends JPanel implements ActionListener,ItemListener{
	// JPanel pTitle; //�����������
	JPanel pContent; // �����Ա��Ϣ�����������
	JScrollPane js; // �����Ա��Ϣ���ڵĹ������

	JTextField tfPersonId; // ��Ա���
	JTextField tfName; // ����
	JTextField tfSex; // �Ա�
	JTextField tfBirth; // ��������
	JTextField tfNat; // ����
	JTextField tfAddress; // ��ַ
	JTextField tfOther; // ����

	JComboBox<String> comboDept; // ѡ����Ա��Ϣ

	JButton btnAdd; // �޸�
	JButton btnClear; // ���

	public Panel12() {
		// ����Ϊ���������
		GridBagLayout gridBag = new GridBagLayout();
		GridBagConstraints cons = null;
		setLayout(gridBag);

		// ��ӱ���
		JLabel lbTitle = new JLabel("�޸���Ա��Ϣ");
		lbTitle.setFont(new Font("����", 0, 16));
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 0;
		gridBag.setConstraints(lbTitle, cons);
		add(lbTitle);

		// �����������
		initContent(); // ��ʼ�������Ա��Ϣ����
		js = new JScrollPane(pContent);
		js.setPreferredSize(new Dimension(450, 380));
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 1;
		gridBag.setConstraints(js, cons);
		add(js);
	}

	public void initContent() {
		// ����������岢���ò��ַ�ʽ
		pContent = new JPanel();
		GridBagLayout layout = new GridBagLayout();
		pContent.setLayout(layout);

		GridBagConstraints cons = null;

		// ��ӵ�1���������Ա��ű�ǩ����Ա����ı�����Ա������ǩ����Ա�����ı���
		// ��Ա��ű�ǩ
		JLabel lbPersonId = new JLabel("��Ա���");
		// lbPersonId.setFont(new Font("����",0,12));
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 0;
		cons.insets = new Insets(10, 10, 10, 1);// �������Ҽ��
		layout.setConstraints(lbPersonId, cons);
		pContent.add(lbPersonId);
		// ��Ա����ı���
		tfPersonId = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 1;
		cons.gridy = 0;
		cons.insets = new Insets(10, 1, 10, 15);
		layout.setConstraints(tfPersonId, cons);
		//��Ա��ų�ʼ��
		tfPersonId.setText("���ѯ��Ա���");
		tfPersonId.setEditable(false);
		
		pContent.add(tfPersonId);
		// ��Ա������ǩ
		JLabel lbName = new JLabel("��Ա����");
		cons = new GridBagConstraints();
		cons.gridx = 2;
		cons.gridy = 0;
		cons.insets = new Insets(10, 15, 10, 1);
		layout.setConstraints(lbName, cons);
		pContent.add(lbName);
		// ��Ա�����ı���
		tfName = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 3;
		cons.gridy = 0;
		cons.insets = new Insets(10, 1, 10, 10);
		layout.setConstraints(tfName, cons);
		pContent.add(tfName);

		// ��ӵ�2��������Ա��ǩ���Ա��ı��򡢳������±�ǩ�����������ı���
		// �Ա��ǩ
		JLabel lbSex = new JLabel("�Ա�");
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 1;
		cons.insets = new Insets(10, 10, 10, 1);
		layout.setConstraints(lbSex, cons);
		pContent.add(lbSex);
		// �Ա��ı���
		tfSex = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 1;
		cons.gridy = 1;
		cons.insets = new Insets(10, 1, 10, 15);
		cons.gridwidth = 3;
		cons.anchor = GridBagConstraints.WEST;
		layout.setConstraints(tfSex, cons);
		pContent.add(tfSex);
		// �������±�ǩ
		JLabel lbBirth = new JLabel("��������");
		cons = new GridBagConstraints();
		cons.gridx = 2;
		cons.gridy = 1;
		cons.insets = new Insets(10, 15, 10, 1);
		layout.setConstraints(lbBirth, cons);
		pContent.add(lbBirth);
		// ���������ı���
		tfBirth = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 3;
		cons.gridy = 1;
		cons.insets = new Insets(10, 1, 10, 10);
		layout.setConstraints(tfBirth, cons);
		pContent.add(tfBirth);

		// ��ӵ�3������������ǩ�������ı��򡢵�ַ��ǩ����ַ�ı���
		// �����ǩ
		JLabel lbNat = new JLabel("�� ��");
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 2;
		cons.insets = new Insets(10, 10, 10, 1);
		layout.setConstraints(lbNat, cons);
		pContent.add(lbNat);
		// �����ı���
		tfNat = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 1;
		cons.gridy = 2;
		cons.insets = new Insets(10, 1, 10, 15);
		layout.setConstraints(tfNat, cons);
		pContent.add(tfNat);
		// ��ַ��ǩ
		JLabel lbAddress = new JLabel("�� ַ");
		cons = new GridBagConstraints();
		cons.gridx = 2;
		cons.gridy = 2;
		cons.insets = new Insets(10, 15, 10, 1);
		layout.setConstraints(lbAddress, cons);
		pContent.add(lbAddress);
		// ��ַ�ı���
		tfAddress = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 3;
		cons.gridy = 2;
		cons.insets = new Insets(10, 1, 10, 10);
		layout.setConstraints(tfAddress, cons);
		pContent.add(tfAddress);

		// ������ǩ
		JLabel lbOther = new JLabel("�� ��");
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 3;
		cons.insets = new Insets(10, 15, 10, 1);
		layout.setConstraints(lbOther, cons);
		pContent.add(lbOther);
		// �����ı���
		tfOther = new JTextField(15);
		cons = new GridBagConstraints();
		cons.gridx = 1;
		cons.gridy = 3;
		cons.gridwidth = 3;
		cons.anchor = GridBagConstraints.WEST;
		cons.insets = new Insets(10, 1, 10, 10);
		layout.setConstraints(tfOther, cons);
		pContent.add(tfOther);
		// ��ӵ�4����������ű�ǩ�����������б�������ǩ�������ı���
		// ���ű�ǩ
		JLabel lbDept = new JLabel("ѡ����Ա��Ϣ");
		cons = new GridBagConstraints();
		cons.gridx = 0;
		cons.gridy = 4;

		cons.insets = new Insets(10, 10, 10, 1);
		layout.setConstraints(lbDept, cons);
		pContent.add(lbDept);
		// ���������б�
		comboDept = new JComboBox<String>();
		comboDept.addItemListener(this);
		// Ϊ���������б��������
		String[] depts = PersonDao.getPersonsForTable1();
		for (int i = 0; i < depts.length; i++) {
			comboDept.addItem(depts[i]);
		}
		cons = new GridBagConstraints();
		cons.gridx = 1;
		cons.gridy = 4;
		cons.insets = new Insets(10, 1, 10, 15);
		layout.setConstraints(comboDept, cons);
		pContent.add(comboDept);

		// ��ӵ�5����������Ӱ�ť����հ�ť��
		// ����
		btnAdd = new JButton("�޸�");
		btnAdd.addActionListener(this);
		cons = new GridBagConstraints();
		cons.gridx = 1;//2
		cons.gridy = 5;//4
		cons.gridwidth = 2;
		cons.insets = new Insets(10, 10, 10, 10);
		layout.setConstraints(btnAdd, cons);
		pContent.add(btnAdd);
		// ���
		btnClear = new JButton("���");
		btnClear.addActionListener(this);
		cons = new GridBagConstraints();
		cons.gridx = 3;//3
		cons.gridy = 5;//4
		cons.gridwidth = 2;
		cons.insets = new Insets(10, 10, 10, 10);
		layout.setConstraints(btnClear, cons);
		pContent.add(btnClear);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		if (e.getSource() == btnAdd) {
			// �ӽ����ȡ����
			String personId = tfPersonId.getText();
			String personName = tfName.getText();
			String personSex = tfSex.getText();
			String personBirth = tfBirth.getText();
			String personNat = tfNat.getText();
			String personAddress = tfAddress.getText();
			String personOther = tfOther.getText();

//			String dept = comboDept.getSelectedItem().toString();

			// ��ȡ���ű��
//			String[] deptParts = dept.split("-");
//			String deptId = deptParts[0];
//			String deptId = tfDeptId.getText();
//			String dept1Name = tfDept1Name.getText();
//			String dept2Name = tfDept2Name.getText();

			// ������֤
//			if(personId==null||personId.equals("")) {
//				JOptionPane.showMessageDialog(null, "�����벿�ű��!");
//				return ;
//			}
			// �����ݷ�װ��dept������
			Person person = new Person();
//			Dept dept = new Dept();
			person.setPersonId(Long.parseLong(personId));
			person.setName(personName);
			person.setSex(personSex);
			person.setBirth(personBirth);
			person.setNat(personNat);
			person.setAddress(personAddress);
//			person.setDeptId(Long.parseLong(deptId));
//			person.setSalary(salary);
			person.setOther(personOther);
//			person.setAssess("δ����");
//			person.setDept1Name(dept1Name);
//			person.setDept2Name(dept2Name);

			// ��ӵ����ݿ���
			PersonDao.update(person);
			JOptionPane.showMessageDialog(null, "��ӳɹ���");

			// ���±������
//			updateTable();
		}
		if (e.getSource() == btnClear) {
			tfPersonId.setText("���ѯ��Ա���");
			tfName.setText(null);
			tfSex.setText(null);
			tfBirth.setText(null);
			tfNat.setText(null);
			tfAddress.setText(null);
			tfOther.setText(null);
		}
	}

	@Override
	public void itemStateChanged(ItemEvent e) {
		// TODO Auto-generated method stub
		if(e.getStateChange() == ItemEvent.SELECTED) {
			String itemSize = (String) e.getItem();
			//��ȡ��Ա���
			String[] deptParts = itemSize.split("-");
			Person person = new Person();
			person.setPersonId(Long.parseLong(deptParts[0]));
			
			String[][] data = new String[10][6];
			data = PersonDao.getPersonsForSelect(person);
			tfPersonId.setText(deptParts[0]);
			for(int i=0;i<data.length;i++) {
//				comboDept.addItem(depts[i]);
//				System.out.println(data[i][3]);
				
				
				tfName.setText(data[i][0]);  //����
				tfSex.setText(data[i][1]);   //�Ա�
				tfBirth.setText(data[i][2]);  //��������
				tfNat.setText(data[i][3]);    //����
				tfAddress.setText(data[i][4]); //��ַ
				tfOther.setText(data[i][5]);   //����˵��
			}
			
		}
	}
}
