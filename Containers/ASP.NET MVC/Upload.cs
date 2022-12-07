[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Open(IFormFile fileTdb) {
    using (var stream = new FileStream(_tmpFilePath, FileMode.Create)) {
        fileTdb.CopyTo(stream);
    }

    _dbManager.OpenDatabase(_tmpFilePath);
    return RedirectToAction("Index", "Home");
}

[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Save() {
    _dbManager.SaveDatabase(_tmpFilePath);
        
    byte[] dbBytes = System.IO.File.ReadAllBytes(_tmpFilePath);
    string fileName = $"{_dbManager.Database.Name}.tdb";

    return File(dbBytes, "application/octet-stream", fileName);
}
