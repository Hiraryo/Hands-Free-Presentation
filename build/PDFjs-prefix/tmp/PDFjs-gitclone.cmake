
if(NOT "/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFjs-prefix/src/PDFjs-stamp/PDFjs-gitinfo.txt" IS_NEWER_THAN "/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFjs-prefix/src/PDFjs-stamp/PDFjs-gitclone-lastrun.txt")
  message(STATUS "Avoiding repeated git clone, stamp file is up to date: '/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFjs-prefix/src/PDFjs-stamp/PDFjs-gitclone-lastrun.txt'")
  return()
endif()

execute_process(
  COMMAND ${CMAKE_COMMAND} -E rm -rf "/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFJS-source"
  RESULT_VARIABLE error_code
  )
if(error_code)
  message(FATAL_ERROR "Failed to remove directory: '/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFJS-source'")
endif()

# try the clone 3 times in case there is an odd git clone issue
set(error_code 1)
set(number_of_tries 0)
while(error_code AND number_of_tries LESS 3)
  execute_process(
    COMMAND "/usr/local/bin/git"  clone --no-checkout --config "advice.detachedHead=false" "https://github.com/mozilla/pdf.js.git" "PDFJS-source"
    WORKING_DIRECTORY "/Users/ryota/Desktop/HandsFreePresentationRails/build"
    RESULT_VARIABLE error_code
    )
  math(EXPR number_of_tries "${number_of_tries} + 1")
endwhile()
if(number_of_tries GREATER 1)
  message(STATUS "Had to git clone more than once:
          ${number_of_tries} times.")
endif()
if(error_code)
  message(FATAL_ERROR "Failed to clone repository: 'https://github.com/mozilla/pdf.js.git'")
endif()

execute_process(
  COMMAND "/usr/local/bin/git"  checkout v1.1.114 --
  WORKING_DIRECTORY "/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFJS-source"
  RESULT_VARIABLE error_code
  )
if(error_code)
  message(FATAL_ERROR "Failed to checkout tag: 'v1.1.114'")
endif()

set(init_submodules TRUE)
if(init_submodules)
  execute_process(
    COMMAND "/usr/local/bin/git"  submodule update --recursive --init 
    WORKING_DIRECTORY "/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFJS-source"
    RESULT_VARIABLE error_code
    )
endif()
if(error_code)
  message(FATAL_ERROR "Failed to update submodules in: '/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFJS-source'")
endif()

# Complete success, update the script-last-run stamp file:
#
execute_process(
  COMMAND ${CMAKE_COMMAND} -E copy
    "/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFjs-prefix/src/PDFjs-stamp/PDFjs-gitinfo.txt"
    "/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFjs-prefix/src/PDFjs-stamp/PDFjs-gitclone-lastrun.txt"
  RESULT_VARIABLE error_code
  )
if(error_code)
  message(FATAL_ERROR "Failed to copy script-last-run stamp file: '/Users/ryota/Desktop/HandsFreePresentationRails/build/PDFjs-prefix/src/PDFjs-stamp/PDFjs-gitclone-lastrun.txt'")
endif()

