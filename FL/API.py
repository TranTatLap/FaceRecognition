from fastapi import FastAPI, File, UploadFile, HTTPException
from fastapi.responses import FileResponse
from typing import List
from zipfile import ZipFile
import os
from starlette.staticfiles import StaticFiles

app = FastAPI()

# Thư mục để lưu trữ các file đã tải lên
UPLOAD_FOLDER = "D:/New folder"
app.mount("/uploads", StaticFiles(directory=UPLOAD_FOLDER), name="uploads")

# Danh sách để lưu trữ thông tin về các file đã tải lên
uploaded_files = []


@app.post("/uploadfiles/")
async def create_upload_files(files: List[UploadFile] = File(...)):
    for file in files:
        # Lưu thông tin về file đã tải lên
        uploaded_files.append({"filename": file.filename, "content_type": file.content_type})

        # Lưu file vào thư mục lưu trữ
        file_path = os.path.join(UPLOAD_FOLDER, file.filename)
        with open(file_path, "wb") as f:
            f.write(file.file.read())

    return {"files_uploaded": [file.filename for file in files]}


@app.get("/download-all/")
async def download_all_files():
    # Kiểm tra xem có file nào đã tải lên không
    if not uploaded_files:
        raise HTTPException(status_code=404, detail="No files found")

    # Lặp qua danh sách các file và trả về một tệp nén chứa tất cả các file
    zip_file_name = "all_files.zip"
    zip_file_path = os.path.join(UPLOAD_FOLDER, zip_file_name)

    with ZipFile(zip_file_path, "w") as zipf:
        for file_info in uploaded_files:
            file_path = os.path.join(UPLOAD_FOLDER, file_info["filename"])
            zipf.write(file_path, os.path.basename(file_path))

    return FileResponse(zip_file_path, media_type="application/zip", filename=zip_file_name)
