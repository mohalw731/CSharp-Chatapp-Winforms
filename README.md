# CSharp-Chatapp-Winforms

Application is made for sole purpose of showing how to implement TcpListener and TcpClient classes, as well as asynchronous read and write functions.
Used ConcurrentDictionary class which is a thread-safe collection of key/value pairs to store client information.
Used Task class to prevent race conditions.
Server uses multithreading to accept clients (i.e. server can accept multiple clients).
