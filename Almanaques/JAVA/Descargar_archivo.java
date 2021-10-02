// Link https://stackoverflow.com/questions/17345623/how-to-prevent-ui-lag-when-updating-notification-while-downloading-file/23107289#23107289
protected String doInBackground(String... sUrl) {
      try {
            String destName = sUrl[1];
            file_Delete(destName); // Just to make sure!

            URL url = new URL(sUrl[0]);
            URLConnection connection = url.openConnection();
            connection.connect();
            int fileLength = connection.getContentLength();

            InputStream input = new BufferedInputStream(url.openStream());
            OutputStream output = new FileOutputStream(destName);

            byte data[] = new byte[1024];
            long total = 0;
            int count;
            while ((count = input.read(data)) != -1) {
                  total += count;
                  publishProgress((int) (total * 100 / fileLength));
                  output.write(data, 0, count);
            }

            byte data[] = new byte[1024];
            long total = 0;
            int count, latestPercentDone;
            int percentDone = -1;
            while ((count = input.read(data)) != -1) {
                  total += count;
                  latestPercentDone = (int) Math.round(total / fileLength * 100.0);
                  if (percentDone != latestPercentDone) {
                        percentDone = latestPercentDone;
                        publishProgress(percentDone);
                  }
                  output.write(data, 0, count);
            }

            output.flush();
            output.close();
            input.close();

      } catch (Exception e) {
            Log.e(TAG, NAME + ": Error downloading file! " + e.getMessage());
            return e.getMessage();
      }

      return null;
}

      // Con ProgressBar
      @Override protected void onProgressUpdate(Integer... progress) {
            super.onProgressUpdate(progress);
            DownloadImage.mProgressDialog.setProgress(progress[0]);
      }

      // Con notificación
      @Override protected void onProgressUpdate(Integer... progress) {
            super.onProgressUpdate(progress);
            // DownloadImage.mProgressDialog.setProgress(progress[0]);

            DownloadImage.myNotification = new NotificationCompat.Builder(c)
            .setContentTitle("Downloading SlapOS")
            .setContentText("Download is " + progress[0] + "% done")
            .setTicker("Downloading...")
            .setOngoing(true)
            .setWhen(System.currentTimeMillis())
            .setProgress(100, progress[0], false)
            .setSmallIcon(R.drawable.icon)
            .build();

            DownloadImage.notificationManager.notify(1, DownloadImage.myNotification);
      }
    


// Link: https://github.com/DWorkS/VolleyPlus/issues/53
      public void DownloadFile(String url, String path) {
            DownloadRequest downloadRequest = new DownloadRequest(url, path, new Response.Listener<String>() {
            @Override
                  public void onResponse(String path) {
                  Log.d("saved in",path);
                  }
            }, new Response.ErrorListener() {
                  @Override
                  public void onErrorResponse(VolleyError volleyError) {
                  Log.d("volleyError", volleyError.toString());
                  }
            });

            downloadRequest.setOnProgressListener(new Response.ProgressListener() {
                  @Override
                  public void onProgress(long downloaded, long totalSize) {
                  int percentage = (int) ((downloaded / ((float) totalSize)) * 100);
                  Log.d("percentage", String.valueOf(percentage) + "%");
                  }
            });

            RequestQueue requestQueue = Volley.newRequestQueue(getApplicationContext());
            requestQueue.add(downloadRequest);
            requestQueue.start();
      }