/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [song_id]
      ,[song_name] AS 歌曲名
      ,[song_ab] AS 拼音名
      ,[song_word_count] AS 歌曲名字数
      ,B.[songtype_name] AS 歌曲类型
      ,N.[singer_NAME] AS 歌手编号
      ,[song_url]	AS 歌曲URL
      ,[song_play_count] AS 播放次数
  FROM [MyKtv].[dbo].[song_info] AS S
  inner join song_type AS B ON B.songtype_id = S.songtype_id
  inner join singer_info AS N ON N.singer_id = S.singer_id