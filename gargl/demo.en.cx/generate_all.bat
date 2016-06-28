@echo off
echo "generate_all.bat script is running in: %CD% "

SET OUT_DIR="%~dp0..\..\Sources\Enc.Game.AppConsole\Generated\\"

echo %OUT_DIR%

mkdir %OUT_DIR%
SET files=penaltypromptedit.gtf 
REM SET files=commonfunctionality.gtf helptopics.gtf leveltaskedit.gtf messageedit.gtf penaltypromptedit.gtf promptedit.gtf separatefunctonality.gtf  


(for %%f in (%files%) do (
	
	echo.
	echo "<<<           ----------------            >>>"
	echo "generate for %%f"
	echo "<<<           ----------------            >>>"
	java -jar JavaGenerator-1.0-SNAPSHOT.jar -input %%f -outdir %OUT_DIR% -lang csharp
))
