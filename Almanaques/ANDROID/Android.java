//***Mandar hasta abajo control con RelativeLayout
--- android:layout_alignParentBottom="true"


//***Dialogo personalizado     
	private void mostrarDialog(View view){
        customDialog = new Dialog(this, R.style.Theme_AppCompat_NoActionBar);

        // Deshabilitamos el t�tulo por defecto
        customDialog.requestWindowFeature(Window.FEATURE_NO_TITLE);

        // Obligamos al usuario a pulsar los botones para cerrarlo
        customDialog.setCancelable(false);

        // Establecemos el contenido de nuestro dialog
        customDialog.setContentView(R.layout.dialog_foto_persona);  * xml del dialogo personalizado

        // Para register.xml
//        etEmailReg = customDialog.findViewById(R.id.etEmailReg);

//        cerrarDialog.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View view) {
//                cerrarDialog();
//            }
//        });

        //Agregar animaci�n a �ste dialogo
        customDialog.getWindow().getAttributes().windowAnimations = R.style.DialogScale;

        // Mostramos el Dialog
        customDialog.show();
        // Para pasarle una animaci�n
        //customDialog.getWindow().getAttributes().windowAnimations = type;
    }

    private void cerrarDialog(){
        customDialog.dismiss();
    }


//*** Dialogo personalizado con AlertBuilder
	    public AlertDialog createCustomDialog(){
        final AlertDialog alertDialog;
        final AlertDialog.Builder builder = new AlertDialog.Builder(this);
        // Get the layout inflater
        LayoutInflater inflater = getLayoutInflater();
        // Inflar y establecer el layout para el dialogo
        // Pasar nulo como vista principal porque va en el dise�o del di�logo
        View v = inflater.inflate(R.layout.dialog_foto_persona, null);
        //builder.setView(inflater.inflate(R.layout.dialog_signin, null))
//        Button btnFire = (Button)v.findViewById(R.id.btn_fire);
        builder.setView(v);
        alertDialog = builder.create();
        // Add action buttons
//        btnFire.setOnClickListener(
//                new View.OnClickListener() {
//                    @Override
//                    public void onClick(View v) {
//                        // Aceptar
//                        alertDialog.dismiss();
//                    }
//                }
//        );
        return alertDialog;
    }

	//Para llamarlo
	createCustomDialog().show();


//*** Manejar excepcion de red
   setContentView(R.layout.user_login);
   if (android.os.Build.VERSION.SDK_INT > 9)
   {
      StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
      StrictMode.setThreadPolicy(policy);
   }


//    Agregado el 29-Sep-2019
//*** Animar elementos de un Recyclerview
    long DURATION = 500;
    private boolean on_attach = true;

    private void setAnimation(View itemView, int i) {
        if(!on_attach){
            i = -1;
        }
        boolean isNotFirstItem = i == -1;
        i++;
        itemView.setAlpha(0.f);
        AnimatorSet animatorSet = new AnimatorSet();
        ObjectAnimator animator = ObjectAnimator.ofFloat(itemView, "alpha", 0.f, 0.5f, 1.0f);
        ObjectAnimator.ofFloat(itemView, "alpha", 0.f).start();
        animator.setStartDelay(isNotFirstItem ? DURATION / 2 : (i * DURATION / 3));
        animator.setDuration(500);
        animatorSet.play(animator);
        animator.start();
    }

    @Override
    public void onAttachedToRecyclerView(RecyclerView recyclerView) {
        // Agregado el 29-Sep-2019
        recyclerView.addOnScrollListener(new RecyclerView.OnScrollListener() {
            @Override
            public void onScrollStateChanged(@NonNull RecyclerView recyclerView, int newState) {
                Log.d(TAG, "onScrollStateChanged: Called " + newState);
                on_attach = false;
                super.onScrollStateChanged(recyclerView, newState);
            }
        });

        super.onAttachedToRecyclerView(recyclerView);
    }

    @Override
    public void onBindViewHolder(MenuViewHolder menuViewHolder, int i) {
        menuViewHolder.menuName.setText(menus.get(i).getNombre());
        menuViewHolder.menuPhoto.setImageResource(menus.get(i).getImagen());

        ViewCompat.setTransitionName(menuViewHolder.menuPhoto, "transicion_" + menuViewHolder.menuName.getText().toString());

        menuViewHolder.menuName.setText(menus.get(i).getNombre());
        Picasso.get().load(menus.get(i).getImagen()).into(menuViewHolder.menuPhoto);


        setAnimation(menuViewHolder.itemView, i);
    }


//***Masonry Layout (Staggered Layout)
    // Recyclerview
    <?xml version="1.0" encoding="utf-8"?>
    <androidx.constraintlayout.widget.ConstraintLayout xmlns:android="http://schemas.android.com/apk/res/android"
        xmlns:app="http://schemas.android.com/apk/res-auto"
        xmlns:tools="http://schemas.android.com/tools"
        android:layout_width="match_parent"
        android:layout_height="match_parent"
        tools:context=".MainActivity">

        <androidx.recyclerview.widget.RecyclerView
            android:id="@+id/recView"
            android:layout_width="match_parent"
            android:layout_height="match_parent" >

        </androidx.recyclerview.widget.RecyclerView>
    </androidx.constraintlayout.widget.ConstraintLayout>
    
    // Item 
    <?xml version="1.0" encoding="utf-8"?>
    <androidx.constraintlayout.widget.ConstraintLayout xmlns:android="http://schemas.android.com/apk/res/android"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        xmlns:app="http://schemas.android.com/apk/res-auto">

        <ImageView
            android:id="@+id/img"
            app:layout_constraintTop_toTopOf="parent"
            app:layout_constraintStart_toStartOf="parent"
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:adjustViewBounds="true"
            android:src="@mipmap/ic_launcher"
            android:scaleType="centerCrop" />

        <TextView
            android:id="@+id/txt"
            app:layout_constraintTop_toBottomOf="@+id/img"
            app:layout_constraintStart_toStartOf="parent"
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:text="Texto"
            android:textSize="36sp"
            android:gravity="center" />


    </androidx.constraintlayout.widget.ConstraintLayout>

    // Adapter
    package julio.pack.masonrylayout;

    import android.content.Context;
    import android.view.LayoutInflater;
    import android.view.View;
    import android.view.ViewGroup;
    import android.widget.ImageView;
    import android.widget.TextView;

    import androidx.annotation.NonNull;
    import androidx.recyclerview.widget.RecyclerView;

    public class MasonryAdapter extends RecyclerView.Adapter<MasonryAdapter.MasonryView> {

        private Context context;

        int[] imgList = {R.drawable.two, R.drawable.one, R.drawable.three, R.drawable.four,
                R.drawable.five, R.drawable.six, R.drawable.seven, R.drawable.eight,
                R.drawable.nine, R.drawable.ten};

        String[] nameList = {"One", "Two", "Three", "Four", "Five", "Six",
                "Seven", "Eight", "Nine", "Ten"};

        public MasonryAdapter(Context context) {
            this.context = context;
        }

        @Override
        public MasonryView onCreateViewHolder(ViewGroup parent, int viewType) {
            View layoutView = LayoutInflater.from(parent.getContext()).inflate(R.layout.tile_masonry, parent, false);
            MasonryView masonryView = new MasonryView(layoutView);
            return masonryView;
        }

        @Override
        public void onBindViewHolder(MasonryView holder, int position) {
            holder.imageView.setImageResource(imgList[position]);
            holder.textView.setText(nameList[position]);
        }

        @Override
        public int getItemCount() {
            return nameList.length;
        }

        class MasonryView extends RecyclerView.ViewHolder {
            ImageView imageView;
            TextView textView;

            public MasonryView(View itemView) {
                super(itemView);

                imageView = (ImageView) itemView.findViewById(R.id.img);
                textView = (TextView) itemView.findViewById(R.id.txt);

            }
        }
    }

    // MainActivity
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        RecyclerView mRecyclerView;
        mRecyclerView = (RecyclerView) findViewById(R.id.recView);
        mRecyclerView.setLayoutManager(new StaggeredGridLayoutManager(2, StaggeredGridLayoutManager.VERTICAL));

        MasonryAdapter adapter = new MasonryAdapter(this);
        mRecyclerView.setAdapter(adapter);

        SpacesItemDecoration decoration = new SpacesItemDecoration(16);
        mRecyclerView.addItemDecoration(decoration);
    }

    //SpacesItemDecoration
    package julio.pack.masonrylayout;

    import android.graphics.Rect;
    import android.view.View;

    import androidx.recyclerview.widget.RecyclerView;

    public class SpacesItemDecoration extends RecyclerView.ItemDecoration {
        private final int mSpace;

        public SpacesItemDecoration(int space) {
            this.mSpace = space;
        }

        @Override
        public void getItemOffsets(Rect outRect, View view, RecyclerView parent, RecyclerView.State state) {
            outRect.left = mSpace;
            outRect.right = mSpace;
            outRect.bottom = mSpace;

            // Add top margin only for the first item to avoid double space between items
            if (parent.getChildAdapterPosition(view) == 0)
                outRect.top = mSpace;
        }
    }

    // Cargar imagen con Picasso
    Picasso.get()
        .load(__Constantes.GET_IP_BASE + ruta_img) // Ruta de la imagen (url de internet por ejemplo)
        .resize(220, 180)
        .centerCrop()
        .placeholder(R.drawable.credit_card_1)
        .error(R.drawable.credit_card)
        .into(imgCuenta); // imgCuenta -> ImageView

   
   // Peticion Volley
   HashMap<String, String> map = new HashMap<>();
   map.put("edad", txtEdad.getText().toString());
   map.put("nombre", txtNombre.getText().toString());
   map.put("ID", id_Persona + "");
   JSONObject objJson = new JSONObject(map);
   Log.d(TAG, objJson.toString());

   if (id_Persona != 0)
       urlPOST = __Constantes.UPDATE;
   else
       urlPOST = __Constantes.AGREGAR;

   Log.d(TAG, "urlPOST: " + urlPOST);

   VolleySingleton.getInstance(getApplicationContext()).addToRequestQueue(
           new JsonObjectRequest(Request.Method.POST, urlPOST, objJson,
                   new Response.Listener<JSONObject>() {
                       @Override
                       public void onResponse(JSONObject  response) {
                           try{
                               Snackbar.make(v, response.getString("mensaje"), Snackbar.LENGTH_LONG).show();
                               Log.d(TAG, "Respuesta: " + response.toString());
                           } catch(Exception e){
                               Log.e(TAG, "Error response: "+ e.getMessage().toString());
                           }

                       }
                   },
                   new Response.ErrorListener() {
                       @Override
                       public void onErrorResponse(VolleyError error) {
                           //Failure Callback
                           Log.e(TAG, "VolleyError: " + error.getMessage());
                       }

                   }
           ){
               @Override
               public Map<String, String> getHeaders() {
                   Map<String, String> headers = new HashMap<String, String>();
                   headers.put("Content-Type", "application/json; charset=utf-8");
                   headers.put("Accept", "application/json");
                   headers.put("persona_edad", "15");

                   return headers;
               }

               @Override
               public String getBodyContentType() {
                   return "application/json; charset=utf-8" + getParamsEncoding();
               }
           }
   );


   //***Código base para crear "AsyncTask"
   new HiloEnSegundoPlano().execute("variable Tipo_empezarBackground", "variable Tipo_empezarBackground", "..."); //Arrancamos el AsyncTask. el método "execute" envía datos directamente a doInBackground()

    private class HiloEnSegundoPlano extends AsyncTask <Tipo_empezarBackground, Tipo_duranteBackground, Tipo_terminarBackground> {

        public HiloEnSegundoPlano(){
                //TODO código del constructor
        }

        @Override
        protected void onPreExecute() {
                //TODO código del onPreExecute (Hilo Principal)
        }

        @Override
        protected Tipo_terminarBackground doInBackground(Tipo_empezarBackground... varEntrarBackground) {
                //TODO código del doInBackground (Hilo en Segundo Plano)

                //...
                publishProgress(valor_Tipo_duranteBackground); //Opcional. Para pasar el valor y llamar a onProgressUpdate()
                //...

                //...
                cancel(true); //Opcional. Para cancelar en vez de ejecutar al terminar onPostExecute(), ejecutar onCancelled(). Comprobar si se ha cancelado con isCancelled()
                //...

                return valor_Tipo_terminarBackground;
        }

        @Override
        protected void onProgressUpdate(Tipo_duranteBackground... varDuranteBackground) {
                //TODO código del onProgressUpdate (Hilo Principal)
        }

        @Override
        protected void onPostExecute(Tipo_terminarBackground varTerminarBackground) {
                //TODO código del onPostExecute (Hilo Principal)
        }

        @Override
        protected void onCancelled (Tipo_terminarBackground varTerminarBackground) {
                //TODO código del onCancelled (Hilo Principal)
        }

    }