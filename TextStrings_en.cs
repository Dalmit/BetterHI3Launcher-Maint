﻿using System.Windows;

namespace BetterHI3Launcher
{
	public partial class App : Application
	{
		public static void TextStrings_English()
		{
			TextStrings.Add("version", "Version");
			TextStrings.Add("binary_prefixes", "KMGTPEZY");
			TextStrings.Add("byte_short", "b");
			TextStrings.Add("bytes_per_second", "B/s");
			TextStrings.Add("outdated", "Outdated");
			TextStrings.Add("enabled", "Enabled");
			TextStrings.Add("disabled", "Disabled");
			TextStrings.Add("button_yes", "Yes");
			TextStrings.Add("button_no", "No");
			TextStrings.Add("button_download", "Download");
			TextStrings.Add("button_downloading", "Downloading");
			TextStrings.Add("button_running", "Running");
			TextStrings.Add("button_update", "Update");
			TextStrings.Add("button_pause", "Pause");
			TextStrings.Add("button_launch", "Launch");
			TextStrings.Add("button_options", "Options");
			TextStrings.Add("button_resume", "Resume");
			TextStrings.Add("button_ok", "OK");
			TextStrings.Add("button_confirm", "Confirm");
			TextStrings.Add("button_cancel", "Cancel");
			TextStrings.Add("button_github", "Go to GitHub repository");
			TextStrings.Add("button_generate", "Generate");
			TextStrings.Add("label_server", "Server");
			TextStrings.Add("label_mirror", "Mirror");
			TextStrings.Add("label_pre_install", "Game Pre-Installation");
			TextStrings.Add("label_get_now", "Get Now");
			TextStrings.Add("label_verifying", "Verifying");
			TextStrings.Add("label_paused", "Paused");
			TextStrings.Add("label_done", "Done");
			TextStrings.Add("label_retry", "Retry");
			TextStrings.Add("label_downloaded_1", "Downloaded {0}%");
			TextStrings.Add("label_downloaded_2", "Download resources:");
			TextStrings.Add("label_eta", "Time remaining:");
			TextStrings.Add("label_speed", "Download speed:");
			TextStrings.Add("introbox_title", "Welcome to Better HI3 Launcher!");
			TextStrings.Add("introbox_msg", "Seems like this is your first time using the launcher. I'm glad you've decided to give it a try so in case you'd like to give feedback don't hesitate to do so by clicking \"Options\" button and selecting \"Send feedback\".\nIf you already have the game installed just press the \"Download\" button and point to where your game is. The launcher will detect your game version automatically and you won't have to download the game again.");
			TextStrings.Add("repairbox_msg", "This will check every game file and attempt to repair if any is broken. It can take a while.\nContinue?\nAvailable mirrors: {0}.\nCurrent mirror maintainer is {1}.");
			TextStrings.Add("fpsinputbox_title", "Enter max FPS cap");
			TextStrings.Add("fpsinputbox_label_combatfps", "FPS in-game");
			TextStrings.Add("fpsinputbox_label_menufps", "FPS in menu");
			TextStrings.Add("resolutioninputbox_title", "Enter custom resolution");
			TextStrings.Add("resolutioninputbox_label_width", "Width");
			TextStrings.Add("resolutioninputbox_label_height", "Height");
			TextStrings.Add("resolutioninputbox_label_fullscreen", "Fullscreen");
			TextStrings.Add("changelogbox_title", "Changelog");
			TextStrings.Add("changelogbox_1_msg", "Better HI3 Launcher has just become even better. Here's what happened:");
			TextStrings.Add("changelogbox_2_msg", "Loading changelog...");
			TextStrings.Add("changelogbox_3_msg", "Failed to load the changelog.");
			TextStrings.Add("aboutbox_msg", "Well it is much more advanced, isn't it? :^)\nThis project was made with hope for many captains to have a better experience with the game.\nIt is not affiliated with miHoYo and is completely open source.\nAny feedback is greatly appreciated.\nSpecial thanks to these GitHub contributors:\nSinsOfSeven - Custom resolution contribution\nProxy-E23 - Spanish language translation\nSpookyKisuy - Portuguese (Brazil) language translation\nbulawin1, Vrontis - German language translation\nKorewaLidesu - Vietnamese language translation\nSm1leAway - Serbian language translation\nVoRTeXStarz - Thai language translation\nTrilip - French language translation\nfabio-silva-pt - Portuguese (Portugal) language translation\nneon-nyan - Indonesian language translation");
			TextStrings.Add("contextmenu_download_cache", "Download cache");
			TextStrings.Add("contextmenu_fix_subtitles", "Fix subtitles");
			TextStrings.Add("contextmenu_repair", "Repair game files");
			TextStrings.Add("contextmenu_move", "Move game files");
			TextStrings.Add("contextmenu_uninstall", "Uninstall game");
			TextStrings.Add("contextmenu_game_settings", "Manage game settings");
			TextStrings.Add("contextmenu_custom_fps", "Set custom FPS cap");
			TextStrings.Add("contextmenu_custom_resolution", "Set custom resolution");
			TextStrings.Add("contextmenu_custom_launch_options", "Set custom launch options");
			TextStrings.Add("contextmenu_reset_download_type", "Reset download type");
			TextStrings.Add("contextmenu_web_profile", "Go to web profile");
			TextStrings.Add("contextmenu_feedback", "Send feedback");
			TextStrings.Add("contextmenu_changelog", "Show changelog");
			TextStrings.Add("contextmenu_custom_background", "Set custom background");
			TextStrings.Add("contextmenu_show_log", "Show log");
			TextStrings.Add("contextmenu_sounds", "Sounds");
			TextStrings.Add("contextmenu_language", "Language");
			TextStrings.Add("contextmenu_language_system", "System Default");
			TextStrings.Add("contextmenu_language_english", "English");
			TextStrings.Add("contextmenu_language_french", "French");
			TextStrings.Add("contextmenu_language_german", "German");
			TextStrings.Add("contextmenu_language_indonesian", "Indonesian");
			TextStrings.Add("contextmenu_language_portuguese_brazil", "Portuguese (Brazil)");
			TextStrings.Add("contextmenu_language_portuguese_portugal", "Portuguese (Portugal)");
			TextStrings.Add("contextmenu_language_russian", "Russian");
			TextStrings.Add("contextmenu_language_serbian", "Serbian");
			TextStrings.Add("contextmenu_language_spanish", "Spanish");
			TextStrings.Add("contextmenu_language_thai", "Thai");
			TextStrings.Add("contextmenu_language_vietnamese", "Vietnamese");
			TextStrings.Add("contextmenu_language_contribute", "Want to help?");
			TextStrings.Add("contextmenu_about", "About");
			TextStrings.Add("progresstext_checking_update", "Checking for update...");
			TextStrings.Add("progresstext_cleaning_up", "Cleaning up...");
			TextStrings.Add("progresstext_downloaded", "Downloaded {0}/{1} ({2})");
			TextStrings.Add("progresstext_downloading_file", "Downloading file {0}/{1}...");
			TextStrings.Add("progresstext_error", "Mistakes were made :^(");
			TextStrings.Add("progresstext_eta", "Estimated time: {0}");
			TextStrings.Add("progresstext_fetching_hashes", "Fetching file hashes...");
			TextStrings.Add("progresstext_generating_hash", "Generating hash for file {0}/{1}...");
			TextStrings.Add("progresstext_initiating_download", "Initiating download...");
			TextStrings.Add("progresstext_mirror_connect", "Connecting to mirror...");
			TextStrings.Add("progresstext_moving_files", "Moving game files...");
			TextStrings.Add("progresstext_uninstalling", "Uninstalling the game...");
			TextStrings.Add("progresstext_unpacking_1", "Unpacking game files...");
			TextStrings.Add("progresstext_unpacking_2", "Unpacking game file {0}/{1}...");
			TextStrings.Add("progresstext_updating_launcher", "Updating launcher...");
			TextStrings.Add("progresstext_verifying_file", "Verifying game file {0}/{1}...");
			TextStrings.Add("progresstext_verifying_files", "Verifying game files...");
			TextStrings.Add("progresstext_zipping", "Adding file {0}/{1} to ZIP archive...");
			TextStrings.Add("msgbox_abort_1_msg", "Are you sure you want to cancel the download and close the launcher?");
			TextStrings.Add("msgbox_abort_2_msg", "Are you sure you want to cancel the download?");
			TextStrings.Add("msgbox_abort_3_msg", "Progress will not be saved.");
			TextStrings.Add("msgbox_abort_4_msg", "Progress will be saved.");
			TextStrings.Add("msgbox_abort_title", "Abort");
			TextStrings.Add("msgbox_conn_bp_error_msg", "Cannot connect to Bp Network:");
			TextStrings.Add("msgbox_conn_mihoyo_error_msg", "Cannot connect to miHoYo servers:");
			TextStrings.Add("msgbox_custom_background_1_msg", "You can select a file to be used as a background.\nIt can be an image or a video.\nRecommended resolution is {0} by {1} pixels.\nContinue?");
			TextStrings.Add("msgbox_custom_background_2_msg", "Select what would you like to do with the background.");
			TextStrings.Add("msgbox_custom_background_3_msg", "Selected file does not have the recommended resolution. You may still use it, but it will be stretched to the window size.\nContinue?");
			TextStrings.Add("msgbox_custom_background_4_msg", "Please select another file.");
			TextStrings.Add("msgbox_custom_background_5_msg", "Selected file is too large.\nYou can use files up to {0} in size.");
			TextStrings.Add("msgbox_custom_background_6_msg", "There is not enough free space on your system drive to use the file.");
			TextStrings.Add("msgbox_custom_background_7_msg", "Selected file is not in a supported format.");
			TextStrings.Add("msgbox_custom_background_8_msg", "Failed to load selected file.");
			TextStrings.Add("msgbox_custom_background_edit", "Change it");
			TextStrings.Add("msgbox_custom_background_delete", "Reset to official");
			TextStrings.Add("msgbox_custom_fps_1_msg", "Values must not be empty.");
			TextStrings.Add("msgbox_custom_fps_2_msg", "Values must not be zero or negative.");
			TextStrings.Add("msgbox_custom_fps_3_msg", "Values lower than 30 are not recommended. Continue?");
			TextStrings.Add("msgbox_custom_fps_4_msg", "In-game and menu FPS cap successfully set to {0} and {1} respectively.");
			TextStrings.Add("msgbox_custom_resolution_1_msg", "Height being greater than width is not recommended.\nContinue?");
			TextStrings.Add("msgbox_custom_resolution_2_msg", "Resolution successfully set to {0}x{1} with fullscreen {2}.");
			TextStrings.Add("msgbox_custom_launch_options_msg", "Advanced users may enter custom launch options here.\nNote: they are applied independently per server.");
			TextStrings.Add("msgbox_download_cache_1_msg", "Full cache is about to be downloaded.\nDownload size: {0}\nUsing mirror: {1}.\nCache last updated: {2}.\nCurrent mirror maintainer is {3}.");
			TextStrings.Add("msgbox_download_cache_2_msg", "The cache is outdated either partially or fully.\nCheck the last update time for the exact date.\nDo you still want to continue?");
			TextStrings.Add("msgbox_download_cache_3_msg", "The entire game cache will be checked and can be downloaded if needed. It can take a while.\nHi3Mirror is a project courtesy of {0}.\nContinue?");
			TextStrings.Add("msgbox_download_type_1_msg", "This will reset game's resource download type in an attempt to fix the infamous update loop which does not let you enter the game.\nContinue?");
			TextStrings.Add("msgbox_download_type_2_msg", "Download type has been reset. Start the game and select \"Download basic resources\".");
			TextStrings.Add("msgbox_download_type_3_msg", "Download type has already been reset. Start the game and select \"Download basic resources\".");
			TextStrings.Add("msgbox_extract_skip_msg", "Unpacking finished, but some files failed to be unpacked. You might want to unpack them manually.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_extract_skip_title", "File skip notice");
			TextStrings.Add("msgbox_feature_not_available_msg", "This feature is not available for selected server.");
			TextStrings.Add("msgbox_fix_subtitles_1_msg", "This will attempt to fix CG subtitles. Make sure you have already downloaded all CGs in the game.\nContinue?");
			TextStrings.Add("msgbox_fix_subtitles_2_msg", "Unpacking subtitle file {0}/{1}...");
			TextStrings.Add("msgbox_fix_subtitles_3_msg", "Checking subtitle file {0}/{1}...");
			TextStrings.Add("msgbox_fix_subtitles_4_msg", "Unpacked subtitles for {0} CGs.");
			TextStrings.Add("msgbox_fix_subtitles_5_msg", "Fixed {0} subtitle files.");
			TextStrings.Add("msgbox_fix_subtitles_6_msg", "No subtitle files were fixed. They are either not downloaded yet or already fixed.");
			TextStrings.Add("msgbox_game_download_error_msg", "An error occurred while downloading game files.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_game_download_error_title", "Error downloading game files");
			TextStrings.Add("msgbox_game_download_mirror_error_msg", "An error occurred while downloading from the mirror.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_game_download_mirror_old_msg", "It seems like the game version on miHoYo servers is newer than the one on the mirror.\nThere is no reason to download an outdated version, ask the mirror maintainer to upload a new version.");
			TextStrings.Add("msgbox_game_download_paused_msg", "The game is not downloaded entirely yet. Changing server or mirror will reset the download progress.\nContinue?");
			TextStrings.Add("msgbox_generic_error_msg", "An error occurred.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_generic_error_title", "Error");
			TextStrings.Add("msgbox_install_dir_error_msg", "An error occurred while selecting game installation directory.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_install_dir_error_title", "Invalid directory");
			TextStrings.Add("msgbox_install_error_msg", "An error occurred while installing game files.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_install_error_title", "Installation error");
			TextStrings.Add("msgbox_install_existing_dir_msg", "The game appears to have already been installed to:\n{0}\nUse this directory?");
			TextStrings.Add("msgbox_install_existing_no_local_version_msg", "Local version could not be determined.\nIs your game updated already? Please choose wisely!\nSelecting \"Yes\" will make you be able to launch the game.\nSelecting \"No\" will make you have to download the game.");
			TextStrings.Add("msgbox_install_little_space_msg", "There is potentially not enough free space on selected device, it is recommended to free up some space or installation may result in failure.\nContinue?");
			TextStrings.Add("msgbox_install_1_msg", "Select where would you like to install the game.");
			TextStrings.Add("msgbox_install_2_msg", "Download size: {0}.");
			TextStrings.Add("msgbox_install_3_msg", "Installation size: {0}.");
			TextStrings.Add("msgbox_install_4_msg", "The game is going to be installed to:\n{0}\nContinue?");
			TextStrings.Add("msgbox_install_title", "Install");
			TextStrings.Add("msgbox_install_wrong_drive_type_msg", "Cannot install on selected device.");
			TextStrings.Add("msgbox_language_msg", "Language is going to be changed to {0} and launcher will be restarted.\nContinue?");
			TextStrings.Add("msgbox_launcher_download_error_msg", "An error occurred while downloading the launcher.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_mirror_error_msg", "There is an error with the mirror. Ask the mirror maintainer to get to the bottom of this.\nMessage: {0}");
			TextStrings.Add("msgbox_mirror_info_msg", "Use this mirror only if you cannot download the game via official miHoYo servers.\nPlease note that it is updated manually.\nContinue?");
			TextStrings.Add("msgbox_move_1_msg", "Select where would you like to move the game.");
			TextStrings.Add("msgbox_move_2_msg", "The game is going to be moved to:\n{0}\nContinue?");
			TextStrings.Add("msgbox_move_3_msg", "Cannot move the game inside the current game directory.");
			TextStrings.Add("msgbox_move_4_msg", "Cannot move the game while the launcher is inside game directory. Move launcher outside the directory and try again.");
			TextStrings.Add("msgbox_move_error_title", "Move error");
			TextStrings.Add("msgbox_move_little_space_msg", "There is potentially not enough free space on selected device, it is recommended to free up some space or move operation may result in failure.\nContinue?");
			TextStrings.Add("msgbox_move_title", "Move");
			TextStrings.Add("msgbox_move_wrong_drive_type_msg", "Cannot move to selected device.");
			TextStrings.Add("msgbox_net_error_msg", "An error occurred while connecting to server:\n{0}");
			TextStrings.Add("msgbox_net_error_title", "Network error");
			TextStrings.Add("msgbox_net_version_old_msg", "This launcher requires .NET Framework 4.6.1 or newer to be installed.");
			TextStrings.Add("msgbox_no_game_dir_msg", "Game directory cannot be found.\nTry reinstalling the game.");
			TextStrings.Add("msgbox_no_game_dir_title", "No game directory");
			TextStrings.Add("msgbox_no_game_exe_msg", "Game executable cannot be found.\nWould you like to reset the installation information?");
			TextStrings.Add("msgbox_no_game_exe_title", "No game executable");
			TextStrings.Add("msgbox_no_video_dir_msg", "Video directory cannot be found.\nTry reinstalling the game.");
			TextStrings.Add("msgbox_notice_title", "Notice");
			TextStrings.Add("msgbox_pre_install_msg", "You can still enter the game when pre-installing. Are you sure you want to download?\nYou can only download from the miHoYo servers.");
			TextStrings.Add("msgbox_process_start_error_msg", "An error occurred while starting the process.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_registry_empty_1_msg", "No value to be tweaked in registry exists.");
			TextStrings.Add("msgbox_registry_empty_2_msg", "Have you run the game yet?");
			TextStrings.Add("msgbox_registry_empty_3_msg", "Try changing video settings in-game first (disabling fullscreen, changing video preset, etc).");
			TextStrings.Add("msgbox_registry_error_msg", "An error occurred while accessing registry.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_registry_error_title", "Registry error");
			TextStrings.Add("msgbox_repair_1_msg", "The version of the game installed differs from repair information on the server. Due to us having to update this information manually, it may not be available for some time.\nPlease try again later.");
			TextStrings.Add("msgbox_repair_2_msg", "No files need any repairs.");
			TextStrings.Add("msgbox_repair_3_msg", "Found {0} corrupted/missing file(s). They need to be repaired by downloading them again.\nBecause technology is awesome, only the required files will be downloaded.\nDownload size: {1}.\nContinue?");
			TextStrings.Add("msgbox_repair_4_msg", "{0} file(s) successfully repaired.");
			TextStrings.Add("msgbox_repair_5_msg", "{0} file(s) failed to be repaired.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_repair_6_msg", "Going to generate a JSON file containing the list of game files and their hashes, then create a ZIP archive with those files.\nContinue?");
			TextStrings.Add("msgbox_repair_7_msg", "Continue to create ZIP file? It definitely takes a while.");
			TextStrings.Add("msgbox_repair_8_msg", "Repair data from the server has a different game version.\nAre you sure you want to run the check?");
			TextStrings.Add("msgbox_start_error_msg", "An error occurred while starting the launcher:\n{0}");
			TextStrings.Add("msgbox_start_error_title", "Startup error");
			TextStrings.Add("msgbox_translations_download_error_msg", "An error occurred while downloading translations.\nOnly English language will be available.");
			TextStrings.Add("msgbox_unhandled_exception_msg", "Oops, something very bad has happened and the launcher must close. But you can help!\nThere is a log file you can send to help diagnose the error.\nDo you want to open the log file now?");
			TextStrings.Add("msgbox_uninstall_1_msg", "Select what would you like to uninstall.");
			TextStrings.Add("msgbox_uninstall_2_msg", "Are you sure you want to uninstall the following?");
			TextStrings.Add("msgbox_uninstall_3_msg", "Are you really sure you want to uninstall the following? :^(");
			TextStrings.Add("msgbox_uninstall_4_msg", "This action is irreversible.\nOnly do this if you are having problems with the game!\nAre you sure you want to continue?");
			TextStrings.Add("msgbox_uninstall_5_msg", "Cannot uninstall the game while the launcher is inside game directory. Move launcher outside the directory and try again.");
			TextStrings.Add("msgbox_uninstall_6_msg", "Sucessfully uninstalled the following:");
			TextStrings.Add("msgbox_uninstall_error_msg", "An error occurred while uninstalling the game.\nFor more information take a look at the log.");
			TextStrings.Add("msgbox_uninstall_error_title", "Uninstallation error");
			TextStrings.Add("msgbox_uninstall_game_files", "Game Files");
			TextStrings.Add("msgbox_uninstall_game_cache", "Game Cache");
			TextStrings.Add("msgbox_uninstall_game_settings", "Game Settings");
			TextStrings.Add("msgbox_uninstall_title", "Uninstall");
			TextStrings.Add("msgbox_update_check_error_msg", "An error occurred while checking for update.\nFor more information take a look at the log.\nRetry?");
			TextStrings.Add("msgbox_update_check_error_title", "Update check error");
			TextStrings.Add("msgbox_update_title", "Update notice");
			TextStrings.Add("msgbox_verify_error_1_msg", "An error occurred while downloading. Please try again.");
			TextStrings.Add("msgbox_verify_error_2_msg", "An error occurred while downloading. File may be corrupt.\nContinue regardless?");
			TextStrings.Add("msgbox_verify_error_title", "File validation error");
		}
	}
}