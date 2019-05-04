#(a)

setwd("D:\\PROJECT\\neural-heart")
library(keras)
Heart <- read.csv("Heart.csv")

summary(Heart)
Heart <- na.omit(Heart)
Heart$X <- NULL
??
#(b)
str(Heart)

Heart$ChestPain <- to_categorical(as.numeric(Heart$ChestPain)-1)
Heart$Thal <- to_categorical(as.numeric(Heart$Thal)-1)
Heart$AHD <- to_categorical(as.numeric(Heart$AHD)-1)

#(c)
n <- nrow(Heart)
p <- ncol(Heart) - 1

set.seed(1)
train <- sample(n, 0.8*n)
train_data <- Heart[train, 1:p]
train_labels <- Heart[train, p+1]

test_data <- Heart[-train, 1:p]
test_labels <- Heart[-train, p+1]

#(d)
train_data <- scale(train_data)

col_means_train <- attr(train_data, "scaled:center")
col_stddevs_train <- attr(train_data, "scaled:scale")
test_data <- scale(test_data,
                   center = col_means_train,
                   scale = col_stddevs_train)

ncol(Heart)
ncol(train_data)

#(e)
use_session_with_seed(1)

#(f)
#number of nodes in input layer: 18
#number of nodes in output layer: 2
#number of nodes in hidden layer: 8
#activation function: binary threshold

model <- keras_model_sequential(layers = list(
            layer_dense(units = 10, activation = 'relu', 
                        input_shape = dim(train_data)[2]),
            layer_dense(units = ncol(train_labels),
                        activation = 'softmax')))

#(g)
compile(model,
        loss = 'categorical_crossentropy',
        optimizer = 'adam',
        metrics = 'accuracy')

#(h)
history <- fit(model,
               train_data, train_labels,
               epochs = 100,
               batch_size = 32,
               validation_split = 0.2)
history

#(i)
#Yes there is overfitting (crossover around 20 epochs)

#(j)
use_session_with_seed(1)
early_stop <- callback_early_stopping(monitor = "val_loss",
                                      patience = 20)

model <- keras_model_sequential(layers = list(
  layer_dense(units = 10, activation = 'relu', 
              input_shape = dim(train_data)[2]),
  layer_dense(units = ncol(train_labels),
              activation = 'softmax')))

compile(model,
        loss = 'categorical_crossentropy',
        optimizer = 'adam',
        metrics = 'accuracy')

history <- fit(model,
               train_data, train_labels,
               epochs = 100,
               batch_size = 32,
               validation_split = 0.2,
               callbacks = list(early_stop))

evaluate(model, test_data, test_labels)

