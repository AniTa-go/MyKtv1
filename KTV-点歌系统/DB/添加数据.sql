--歌手分类表
insert into singer_type
values('大陆');
insert into singer_type
select '香港' union
select '台湾' union
select '欧美' union
select '日韩'

--歌手表
insert into singer_info
values('Avril Ramona Lavigne ',4,'女','E:\KTV-点歌系统\素材\资源\singerPhoto');
insert into singer_info
select 'bobo',1,'组合','E:\KTV-点歌系统\素材\资源\singerPhoto\bobo.jpg' union
select 'Michael Jackson',4,'男','E:\KTV-点歌系统\素材\资源\singerPhoto\Michael Jackson.jpg' union
select 'super junior',5,'组合','E:\KTV-点歌系统\素材\资源\singerPhoto\super junior.jpg' union
select '安室奈美惠',5,'女','E:\KTV-点歌系统\素材\资源\singerPhoto\安室奈美惠.jpg' union
select '侧田',2,'男','E:\KTV-点歌系统\素材\资源\singerPhoto\侧田.jpg' union
select '东方神起',5,'组合','E:\KTV-点歌系统\素材\资源\singerPhoto\东方神起.jpg' union
select '方大同',2,'男','E:\KTV-点歌系统\素材\资源\singerPhoto\方大同.jpg' union
select '何韵诗',2,'女','E:\KTV-点歌系统\素材\资源\singerPhoto\何韵诗.jpg' union
select '后街男孩',4,'组合','E:\KTV-点歌系统\素材\资源\singerPhoto\后街男孩.jpg' union
select '后弦',1,'男','E:\KTV-点歌系统\素材\资源\singerPhoto\后弦.jpg' union
select '李孝利',5,'女','E:\KTV-点歌系统\素材\资源\singerPhoto\李孝利.jpg' union
select '李宇春',1,'女','E:\KTV-点歌系统\素材\资源\singerPhoto\李宇春.jpg' union
select '林肯公园',4,'组合','E:\KTV-点歌系统\素材\资源\singerPhoto\林肯公园.jpg' union
select '苏打绿',3,'组合','E:\KTV-点歌系统\素材\资源\singerPhoto\苏打绿.jpg' union
select '王若琳',3,'女','E:\KTV-点歌系统\素材\资源\singerPhoto\王若琳.jpg' union
select '薛之谦',1,'男','E:\KTV-点歌系统\素材\资源\singerPhoto\薛之谦.jpg'

--歌曲分类表
insert into song_type
values('热门流行');
insert into song_type
values('经典老歌');
insert into song_type
values('影视金曲');
insert into song_type
values('游戏动漫');
insert into song_type
values('戏曲');
insert into song_type
values('儿歌');

insert into song_info
values('alarm','alarm',5,1,5,'E:\KTV-点歌系统\素材\资源\song\alarm.MP3',0);
insert into song_info
SELECT 'anyclub','anyclub',8,1,12,'E:\KTV-点歌系统\素材\资源\song\anyclub.MP3',0 UNION
SELECT 'as long as you love me','as long as you love me',17,2,10,'E:\KTV-点歌系统\素材\资源\song\as long as you love me.MP3',0 UNION
SELECT 'baby dont cry','baby dont cry',11,1,5,'E:\KTV-点歌系统\素材\资源\song\baby dont cry.MP3',0 UNION
SELECT 'BEAT IT','BEAT IT',6,2,3,'E:\KTV-点歌系统\素材\资源\song\BEAT IT.MP3',0 UNION
SELECT 'DANGEROUS','DANGEROUS',9,2,3,'E:\KTV-点歌系统\素材\资源\song\DANGEROUS.MP3',0 UNION
SELECT 'everybody','everybody',9,1,10,'E:\KTV-点歌系统\素材\资源\song\everybody.MP3',0 UNION
SELECT 'girlfriend','girlfriend',10,1,1,'E:\KTV-点歌系统\素材\资源\song\girlfriend.MP3',0 UNION
SELECT 'Larger Than Life','Larger Than Life',14,2,10,'E:\KTV-点歌系统\素材\资源\song\Larger Than Life.MP3',0 UNION
SELECT 'losinggrip','losinggrip',10,1,1,'E:\KTV-点歌系统\素材\资源\song\losinggrip.MP3',0 UNION
SELECT 'myway','myway',5,1,8,'E:\KTV-点歌系统\素材\资源\song\myway.MP3',0 UNION
SELECT 'nobody s listening','nobody s listening',16,2,10,'E:\KTV-点歌系统\素材\资源\song\nobody s listening.MP3',0 UNION
SELECT 'THRILLER','THRILLER',8,2,3,'E:\KTV-点歌系统\素材\资源\song\alarm.MP3',0 UNION
SELECT 'u','u',1,1,4,'E:\KTV-点歌系统\素材\资源\song\u.MP3',0 UNION
SELECT 'When you are gone','When you are gone',14,1,1,'E:\KTV-点歌系统\素材\资源\song\When you are gone.MP3',0 UNION
SELECT '不要爱上她','byast',5,1,12,'E:\KTV-点歌系统\素材\资源\song\不要爱上她.MP3',0 UNION
SELECT '不要爱她','byat',4,1,12,'E:\KTV-点歌系统\素材\资源\song\不要爱她.MP3',0 UNION
SELECT '传说','cs',2,1,17,'E:\KTV-点歌系统\素材\资源\song\传说.MP3',0 UNION
SELECT '单车恋人','dclr',4,1,11,'E:\KTV-点歌系统\素材\资源\song\单车恋人.MP3',0 UNION
SELECT '感动','gd',2,2,6,'E:\KTV-点歌系统\素材\资源\song\感动.MP3',0 UNION
SELECT '给安娜','gan',3,1,11,'E:\KTV-点歌系统\素材\资源\song\给安娜.MP3',0 UNION
SELECT '够不够','gbg',3,1,8,'E:\KTV-点歌系统\素材\资源\song\够不够.MP3',0 UNION
SELECT '黑白','hb',2,1,8,'E:\KTV-点歌系统\素材\资源\song\黑白.MP3',0 UNION
SELECT '黄色枫叶','hsfy',4,1,17,'E:\KTV-点歌系统\素材\资源\song\黄色枫叶.MP3',0 UNION
SELECT '梨花香','lhx',3,1,13,'E:\KTV-点歌系统\素材\资源\song\梨花香.MP3',0 UNION
SELECT '恋爱新手','laxs',4,1,2,'E:\KTV-点歌系统\素材\资源\song\恋爱新手.MP3',0 UNION
SELECT '玫瑰玫瑰我爱你','mgmgwan',7,2,16,'E:\KTV-点歌系统\素材\资源\song\玫瑰玫瑰我爱你.MP3',0 UNION
SELECT '迷宫','mg',2,1,16,'E:\KTV-点歌系统\素材\资源\song\迷宫.MP3',0 UNION
SELECT '女人心','nrx',3,1,13,'E:\KTV-点歌系统\素材\资源\song\女人心.MP3',0 UNION
SELECT '桥段','qd',2,1,11,'E:\KTV-点歌系统\素材\资源\song\桥段.MP3',0 UNION
SELECT '情歌','qg',2,1,6,'E:\KTV-点歌系统\素材\资源\song\情歌.MP3',0 UNION
SELECT '认真的雪','rzdx',4,1,17,'E:\KTV-点歌系统\素材\资源\song\认真的雪.MP3',0 UNION
SELECT '日光','rg',2,1,15,'E:\KTV-点歌系统\素材\资源\song\日光.MP3',0 UNION
SELECT '如果爱','rga',3,1,8,'E:\KTV-点歌系统\素材\资源\song\如果爱.MP3',0 UNION
SELECT '三人游','sry',3,1,8,'E:\KTV-点歌系统\素材\资源\song\三人游.MP3',0 UNION
SELECT '傻瓜','sg',2,1,7,'E:\KTV-点歌系统\素材\资源\song\傻瓜.MP3',0 UNION
SELECT '伤城秘密','scmm',4,1,9,'E:\KTV-点歌系统\素材\资源\song\伤城秘密.MP3',0 UNION
SELECT '蜀绣','sx',2,1,13,'E:\KTV-点歌系统\素材\资源\song\蜀绣.MP3',0 UNION
SELECT '万花筒','wht',3,1,9,'E:\KTV-点歌系统\素材\资源\song\万花筒.MP3',0 UNION
SELECT '我抱着我','wbzw',4,1,4,'E:\KTV-点歌系统\素材\资源\song\我抱着我.MP3',0 UNION
SELECT '西厢','xx',2,1,11,'E:\KTV-点歌系统\素材\资源\song\西厢.MP3',0 UNION
SELECT '喜欢你的理由','xhndly',6,1,4,'E:\KTV-点歌系统\素材\资源\song\喜欢你的理由.MP3',0 UNION
SELECT '小情歌','xqg',3,1,15,'E:\KTV-点歌系统\素材\资源\song\小情歌.MP3',0 UNION
SELECT '小宇宙','xyz',3,1,15,'E:\KTV-点歌系统\素材\资源\song\小宇宙.MP3',0 UNION
SELECT '信我','xw',2,1,6,'E:\KTV-点歌系统\素材\资源\song\信我.MP3',0 UNION
SELECT '有你的快乐','yndkl',5,1,16,'E:\KTV-点歌系统\素材\资源\song\有你的快乐.MP3',0 UNION
SELECT '左边','zb',2,1,15,'E:\KTV-点歌系统\素材\资源\song\左边.MP3',0

SELECT TOP 1000 [singer_id]
      ,[singer_name]
      ,[singertype_id]
      ,[singer_sex]
      ,[singer_photo_url]
  FROM [MyKtv].[dbo].[singer_info]
  
  
  --添加一名管理员
  insert into admin_info
  values('asd',5);
  
  --添加路径
  insert into resource_path
  values('歌手图片','E:\KTV-点歌系统\素材\资源\singerPhoto');
  insert into resource_path
  values('歌曲途径','E:\KTV-点歌系统\素材\资源\song');

