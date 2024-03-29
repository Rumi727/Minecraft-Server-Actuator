# Minecraft Server Actuator
마인크래프트 서버 구동기 입니다

윈도우 7 ~ 11 까지 작동합니다

32비트는 테스트 안해봤습니다

(비스타는 테스트 못해봤습니다, 되면 예기해주세요)
#
<img src="오류 창.png" title="오류 창"></img>

윈도우 7에서 저런 오류가 발생한다면 윈도우 7의 모든 업데이트를 설치해주세요 (무슨 업데이트를 설치해야하는지는 저도 잘 모르갰습니다...)



## 라이선스
TEAM Bucket 블랙리스트에 등록된 사람은 등록된 기간의 모든 커밋 또는 릴리즈 등 제 모든 창작물을 이용, 변경 등을 할 수 없습니다 (2022-07-28 0:53 시간 이후의 만들어진 창작물만 해당)  
(예: a라는 사람이 2022-8-01부터 2022-8-23까지 블랙리스트에 등록되어있으면 그 기간 동안 생성된 커밋과 릴리즈를 등 올라온 모든 창작물을 사용할 수 없다는 뜻)

위에 해당하지 않는다면, 파일에 작성되어있는 라이선스를 따르게 됩니다

[TEAM Bucket 블랙리스트에 등록된 사용자 목록](https://docs.google.com/document/d/1A8kz4DJOdLEtf-kybrKnGR51XDNZVHmojCU86KaDgKg)

이러한 라이선스가 [오픈 소스 정의](https://opensource.org/osd)와 일치하지 않다는것을 알고있습니다  
하지만 상관 없습니다  
블랙리스트에 등록될려면 적어도 테러 정돈 해야 등록될 정도로 매우 빡빡하며 등록된 사람들 전부 대부분의 사람들이 납득 가능한 이유가 있습니다



## 사용 방법
서버 켜기를 누르면 폴더 선택 창이 뜰탠데, 서버 폴더를(자바 파일이 있는곳) 선택하면 됩니다

GUI에 써져있는것 그대로 작동합니다

명령어 입력란에 위, 아래 방향키를 입력하면

CMD처럼 전에 썼던 명령어가 자동으로 입력됩니다 (다만 입력하고 있었던 명령어로는 돌아오지 못합니다)



## 설정
처음 프로그램을 키면 생성되는 config.json에서 설정을 바꿀수 있습니다

AutoStartPath: 서버 구동기를 킬때 설정된 경로로 서버를 자동으로 킵니다 (jar 파일 재외!!) 기본값은 "" 입니다

Ram: 서버의 램을 설정합니다 단위는 GB이며 기본값은 1입니다

ServerName: 서버의 jar 파일의 이름을 설정합니다 (확장자 재외) 기본값은 "server" 입니다

ServerStopCommand: 서버를 종료할때 사용하는 명령어를 결정합니다 기본값은 "stop" 입니다

ServerReloadCommand: 서버를 리로드 할때 사용하는 명령어를 결정합니다 기본값은 "reload" 입니다

ServerDatapackReloadCommand: 서버의 데이터팩을 리로드 할때 사용하는 명령어를 결정합니다 기본값은 "minecraft:reload" 입니다

TaskkillCommand: 서버를 강제종료할때 사용하는 cmd 명령어를 결정합니다 기본값은 "taskkill /f /im java.exe" 입니다

Show_the_authorship_of_the_dll_and_package_file_used_in_the_log: 켜져있을경우 로그에 dll의 출처를 표시합니다 기본값은 true 입니다

Dark: 켜져있을경우 프로그램을 다크테마로 변경시킵니다 기본값은 false 이며, 윈도우 10 이상에서는 사용이 불가능합니다 (윈도우의 색 설정에서 앱을 다크 모드로 바꿔야합니다)

GUIHide: 프로그램을 실행할때 자동으로 트레이 아이콘으로 숨길지 결정합니다 기본값은 false 입니다



## CMD 인자
/asp string = AutoStartPath

/r int = Ram

/sn string = ServerName

/src string = ServerReloadCommand

/sdrc string = ServerDatapackReloadCommand

/ssc string = ServerStopCommand

/stc string = TaskkillCommand



## 미리보기
서버가 꺼져있을때

<img src="서버 꺼짐.png" title="서버 꺼짐"></img>

#

서버가 켜져있을때

<img src="서버 켜짐.png" title="서버 켜짐"></img>
#
~~사실 나 혼자 쓸려고 만든~~
