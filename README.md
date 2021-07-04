# Minecraft Server Actuator
마인크래프트 서버 구동기 입니다
윈도우 7 ~ 11 까지 작동합니다

(비스타는 테스트 못해봤습니다, 되면 예기해주세요)
#

<img src="오류 창.png" title="오류 창"></img>

윈도우 7에서 저런 오류가 발생한다면 윈도우 7의 모든 업데이트를 설치해주세요 (무슨 업데이트를 설치해야하는지는 저도 잘 모르갰습니다...)




## 사용 방법
GUI에 써져있는것 그대로 작동합니다




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
