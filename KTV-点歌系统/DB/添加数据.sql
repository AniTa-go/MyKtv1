--���ַ����
insert into singer_type
values('��½');
insert into singer_type
select '���' union
select '̨��' union
select 'ŷ��' union
select '�պ�'

--���ֱ�
insert into singer_info
values('Avril Ramona Lavigne ',4,'Ů','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto');
insert into singer_info
select 'bobo',1,'���','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\bobo.jpg' union
select 'Michael Jackson',4,'��','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\Michael Jackson.jpg' union
select 'super junior',5,'���','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\super junior.jpg' union
select '����������',5,'Ů','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\����������.jpg' union
select '����',2,'��','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\����.jpg' union
select '��������',5,'���','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\��������.jpg' union
select '����ͬ',2,'��','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\����ͬ.jpg' union
select '����ʫ',2,'Ů','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\����ʫ.jpg' union
select '����к�',4,'���','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\����к�.jpg' union
select '����',1,'��','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\����.jpg' union
select '��Т��',5,'Ů','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\��Т��.jpg' union
select '���',1,'Ů','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\���.jpg' union
select '�ֿϹ�԰',4,'���','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\�ֿϹ�԰.jpg' union
select '�մ���',3,'���','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\�մ���.jpg' union
select '������',3,'Ů','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\������.jpg' union
select 'Ѧ֮ǫ',1,'��','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto\Ѧ֮ǫ.jpg'

--���������
insert into song_type
values('��������');
insert into song_type
values('�����ϸ�');
insert into song_type
values('Ӱ�ӽ���');
insert into song_type
values('��Ϸ����');
insert into song_type
values('Ϸ��');
insert into song_type
values('����');

insert into song_info
values('alarm','alarm',5,1,5,'E:\KTV-���ϵͳ\�ز�\��Դ\song\alarm.MP3',0);
insert into song_info
SELECT 'anyclub','anyclub',8,1,12,'E:\KTV-���ϵͳ\�ز�\��Դ\song\anyclub.MP3',0 UNION
SELECT 'as long as you love me','as long as you love me',17,2,10,'E:\KTV-���ϵͳ\�ز�\��Դ\song\as long as you love me.MP3',0 UNION
SELECT 'baby dont cry','baby dont cry',11,1,5,'E:\KTV-���ϵͳ\�ز�\��Դ\song\baby dont cry.MP3',0 UNION
SELECT 'BEAT IT','BEAT IT',6,2,3,'E:\KTV-���ϵͳ\�ز�\��Դ\song\BEAT IT.MP3',0 UNION
SELECT 'DANGEROUS','DANGEROUS',9,2,3,'E:\KTV-���ϵͳ\�ز�\��Դ\song\DANGEROUS.MP3',0 UNION
SELECT 'everybody','everybody',9,1,10,'E:\KTV-���ϵͳ\�ز�\��Դ\song\everybody.MP3',0 UNION
SELECT 'girlfriend','girlfriend',10,1,1,'E:\KTV-���ϵͳ\�ز�\��Դ\song\girlfriend.MP3',0 UNION
SELECT 'Larger Than Life','Larger Than Life',14,2,10,'E:\KTV-���ϵͳ\�ز�\��Դ\song\Larger Than Life.MP3',0 UNION
SELECT 'losinggrip','losinggrip',10,1,1,'E:\KTV-���ϵͳ\�ز�\��Դ\song\losinggrip.MP3',0 UNION
SELECT 'myway','myway',5,1,8,'E:\KTV-���ϵͳ\�ز�\��Դ\song\myway.MP3',0 UNION
SELECT 'nobody s listening','nobody s listening',16,2,10,'E:\KTV-���ϵͳ\�ز�\��Դ\song\nobody s listening.MP3',0 UNION
SELECT 'THRILLER','THRILLER',8,2,3,'E:\KTV-���ϵͳ\�ز�\��Դ\song\alarm.MP3',0 UNION
SELECT 'u','u',1,1,4,'E:\KTV-���ϵͳ\�ز�\��Դ\song\u.MP3',0 UNION
SELECT 'When you are gone','When you are gone',14,1,1,'E:\KTV-���ϵͳ\�ز�\��Դ\song\When you are gone.MP3',0 UNION
SELECT '��Ҫ������','byast',5,1,12,'E:\KTV-���ϵͳ\�ز�\��Դ\song\��Ҫ������.MP3',0 UNION
SELECT '��Ҫ����','byat',4,1,12,'E:\KTV-���ϵͳ\�ز�\��Դ\song\��Ҫ����.MP3',0 UNION
SELECT '��˵','cs',2,1,17,'E:\KTV-���ϵͳ\�ز�\��Դ\song\��˵.MP3',0 UNION
SELECT '��������','dclr',4,1,11,'E:\KTV-���ϵͳ\�ز�\��Դ\song\��������.MP3',0 UNION
SELECT '�ж�','gd',2,2,6,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�ж�.MP3',0 UNION
SELECT '������','gan',3,1,11,'E:\KTV-���ϵͳ\�ز�\��Դ\song\������.MP3',0 UNION
SELECT '������','gbg',3,1,8,'E:\KTV-���ϵͳ\�ز�\��Դ\song\������.MP3',0 UNION
SELECT '�ڰ�','hb',2,1,8,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�ڰ�.MP3',0 UNION
SELECT '��ɫ��Ҷ','hsfy',4,1,17,'E:\KTV-���ϵͳ\�ز�\��Դ\song\��ɫ��Ҷ.MP3',0 UNION
SELECT '�滨��','lhx',3,1,13,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�滨��.MP3',0 UNION
SELECT '��������','laxs',4,1,2,'E:\KTV-���ϵͳ\�ز�\��Դ\song\��������.MP3',0 UNION
SELECT 'õ��õ���Ұ���','mgmgwan',7,2,16,'E:\KTV-���ϵͳ\�ز�\��Դ\song\õ��õ���Ұ���.MP3',0 UNION
SELECT '�Թ�','mg',2,1,16,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�Թ�.MP3',0 UNION
SELECT 'Ů����','nrx',3,1,13,'E:\KTV-���ϵͳ\�ز�\��Դ\song\Ů����.MP3',0 UNION
SELECT '�Ŷ�','qd',2,1,11,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�Ŷ�.MP3',0 UNION
SELECT '���','qg',2,1,6,'E:\KTV-���ϵͳ\�ز�\��Դ\song\���.MP3',0 UNION
SELECT '�����ѩ','rzdx',4,1,17,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�����ѩ.MP3',0 UNION
SELECT '�չ�','rg',2,1,15,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�չ�.MP3',0 UNION
SELECT '�����','rga',3,1,8,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�����.MP3',0 UNION
SELECT '������','sry',3,1,8,'E:\KTV-���ϵͳ\�ز�\��Դ\song\������.MP3',0 UNION
SELECT 'ɵ��','sg',2,1,7,'E:\KTV-���ϵͳ\�ز�\��Դ\song\ɵ��.MP3',0 UNION
SELECT '�˳�����','scmm',4,1,9,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�˳�����.MP3',0 UNION
SELECT '����','sx',2,1,13,'E:\KTV-���ϵͳ\�ز�\��Դ\song\����.MP3',0 UNION
SELECT '��Ͳ','wht',3,1,9,'E:\KTV-���ϵͳ\�ز�\��Դ\song\��Ͳ.MP3',0 UNION
SELECT '�ұ�����','wbzw',4,1,4,'E:\KTV-���ϵͳ\�ز�\��Դ\song\�ұ�����.MP3',0 UNION
SELECT '����','xx',2,1,11,'E:\KTV-���ϵͳ\�ز�\��Դ\song\����.MP3',0 UNION
SELECT 'ϲ���������','xhndly',6,1,4,'E:\KTV-���ϵͳ\�ز�\��Դ\song\ϲ���������.MP3',0 UNION
SELECT 'С���','xqg',3,1,15,'E:\KTV-���ϵͳ\�ز�\��Դ\song\С���.MP3',0 UNION
SELECT 'С����','xyz',3,1,15,'E:\KTV-���ϵͳ\�ز�\��Դ\song\С����.MP3',0 UNION
SELECT '����','xw',2,1,6,'E:\KTV-���ϵͳ\�ز�\��Դ\song\����.MP3',0 UNION
SELECT '����Ŀ���','yndkl',5,1,16,'E:\KTV-���ϵͳ\�ز�\��Դ\song\����Ŀ���.MP3',0 UNION
SELECT '���','zb',2,1,15,'E:\KTV-���ϵͳ\�ز�\��Դ\song\���.MP3',0

SELECT TOP 1000 [singer_id]
      ,[singer_name]
      ,[singertype_id]
      ,[singer_sex]
      ,[singer_photo_url]
  FROM [MyKtv].[dbo].[singer_info]
  
  
  --���һ������Ա
  insert into admin_info
  values('asd',5);
  
  --���·��
  insert into resource_path
  values('����ͼƬ','E:\KTV-���ϵͳ\�ز�\��Դ\singerPhoto');
  insert into resource_path
  values('����;��','E:\KTV-���ϵͳ\�ز�\��Դ\song');

